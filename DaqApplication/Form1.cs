
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Linq;
using System.Collections.Generic;


using System.Windows.Forms;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Dsp;

namespace DaqApplication
{

    public partial class Form1 : Form
    {
        private const int Fields = 20;
        internal class TaskSetting
        {
            public List<string> DeviceNames { get; set; }
            public double SampleRate { get; set; }
            public int SamplePerChannel { get; set; }
            public double MaxValue { get; set; }
            public TimeSpan Duration { get; set; }
            

            public TaskSetting()
            {
                DeviceNames = new List<string>();
                string device = Properties.Settings.Default.Channel_1;
                DeviceNames.Add(device);
                device = Properties.Settings.Default.Channel_2;
                DeviceNames.Add(device);

                SampleRate = Properties.Settings.Default.SamplingRate;
                SamplePerChannel = (int)( Properties.Settings.Default.SamplingRate * Properties.Settings.Default.Duration);
                MaxValue = Properties.Settings.Default.MaxValue;

                Duration = TimeSpan.FromSeconds(Properties.Settings.Default.Duration);
            }

            public TaskSetting(string name, double rate, int sample, double max, double duration)
            {
                DeviceNames = new List<string>();
                DeviceNames.Add(name);

                SampleRate = rate;
                SamplePerChannel = sample;
                MaxValue = max;

                Duration = TimeSpan.FromSeconds(duration);
            }
        }


        private int _AveragedCount = 0;
        private TaskSetting _Setting;
        private System.Diagnostics.Stopwatch _ElapseTime;
        private List<List<double>> _Maxes = new List<List<double>>();
        private List<List<double>> _Mins = new List<List<double>>();
        private List<double> _Average = new List<double>();
        private double[] _XAxis = null;
        private double _LastIndex = 0;

        private ScatterPlot[] _RealTimePlots = new ScatterPlot[2];
        private ScatterPlot[] _FFTPlots = new ScatterPlot[2];

        private bool[] _EnableChannels = new bool[2];

        private List<List<AnalogWaveform<double>>> _WaveformData = new List<List<AnalogWaveform<double>>>();

        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error init component:" + ex.Message);
                return; // throw;
            }


            try
            {
                _Setting = new TaskSetting();

                _RealTimePlots[0] = waveformPlotReal1;
                _RealTimePlots[1] = waveformPlotReal2;

                _FFTPlots[0] = waveformPlotFft1;
                _FFTPlots[1] = waveformPlotFft2;

                _EnableChannels[0] = true;
                _EnableChannels[1] = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error init settings component:" + ex.Message);
                return; // throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_EnableChannels[0] && !_EnableChannels[1])
            {
                MessageBox.Show("Pls firstly set the channels to be tested");

                return;
            }

            try
            {
                button1.Enabled = false;

                InitUI();
                InitData();

                foreach (string item in _Setting.DeviceNames)
                {
                    _Maxes.Add(new List<double>());
                    _Mins.Add(new List<double>());

                    _Average.Add(0.0f);

                    _WaveformData.Add(new List<AnalogWaveform<double>>());
                }
                
                daqTask4474Component1.DeviceNames = _Setting.DeviceNames;
                daqTask4474Component1.Rate = _Setting.SampleRate;
                daqTask4474Component1.Max = _Setting.MaxValue;
                daqTask4474Component1.SamplePerChannel = _Setting.SamplePerChannel;

                
                daqTask4474Component1.ReadAsync();

                _ElapseTime = System.Diagnostics.Stopwatch.StartNew();

            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
            }
        }

        private void daqTask4474Component1_ReadCompleted(object sender, DaqTask4474ComponentReadCompletedEventArgs e)
        {
            NationalInstruments.AnalogWaveform<double>[] acquiredData = e.GetData();

            _AveragedCount++;

            double interval = 1.0 / _Setting.SampleRate;
            System.Threading.Tasks.Parallel.For(0, 2, i =>
                {
                    if (!_EnableChannels[i])
                    {
                        return;
                    }

                    
                    double[] data = acquiredData[i].GetRawData();
                    int dataCount = data.Length / Fields;
                    for (int l = 0; l < Fields; l++)
                    {
                        double min = 0, max = 0;
                        double[] subData = new double[dataCount];
                        Array.Copy(data, l * dataCount, subData, 0, dataCount);

                        ArrayOperation.MaxMin1D(subData, out max, out min);
                        _Maxes[i].Add(max);
                        _Mins[i].Add(min);
                    }

                    
                    _Average[i] += ArrayOperation.Sum1D(data) / data.Length;

                    
                    //Modify the timing information so that the waveform charted is continuous.
                    
                    TimeSpan timeOffset = TimeSpan.FromSeconds(acquiredData[i].SampleCount * 1.0 / _Setting.SampleRate);
                    DateTime latestDateTime = new DateTime(0);

                    _XAxis = new double[acquiredData[i].SampleCount];
                    for (int mm = 0; mm < acquiredData[i].SampleCount; mm++)
                    {
                        _XAxis[mm] = _LastIndex + mm * interval;
                    }

                    _RealTimePlots[i].PlotXYAppend(_XAxis, acquiredData[i].GetRawData());


                    _WaveformData[i].Add(acquiredData[i]);
                });

            _LastIndex += acquiredData[0].SampleCount * interval;

            //write data into file
            System.IO.TextWriter writer = new System.IO.StreamWriter("TestData.csv", false);
            double[] data0 = acquiredData[0].GetRawData();
            double[] data1 = acquiredData[1].GetRawData();
            for (int i = 0; i < data0.Length; i++)
            {
                if (_EnableChannels[0])
                {
                    writer.Write(string.Format("{0:F4},", data0[i]));
                }
                if (_EnableChannels[1])
                {
                    writer.Write(string.Format("{0:F4}", data1[i]));
                }

                writer.WriteLine();
            }
            writer.Close();
            
            
            
            if (_ElapseTime.Elapsed < _Setting.Duration)
            {
                daqTask4474Component1.ReadAsync();
            }
            else
            {
                daqTask4474Component1.StopTask();

                //calculate Min/Max
                for (int i = 0; i < 2; i++)
                {
                    if (!_EnableChannels[i])
                    {
                        continue;
                    }

                    double max, min;
                    min = ArrayOperation.Sum1D(_Mins[i].ToArray());
                    min /= _Mins[i].Count;
                    _Mins[i][0] = min;

                    max = ArrayOperation.Sum1D(_Maxes[i].ToArray());
                    max /= _Maxes[i].Count;
                    _Maxes[i][0] = max;

                    _Average[i] /= _AveragedCount;
                }


                //calculate FFT
                for (int i = 0; i < 2; i++)
                {
                    if (!_EnableChannels[i])
                    {
                        continue;
                    }

                    double[] rawData = new double[0];
                    foreach (AnalogWaveform<double> data in _WaveformData[i])
                    {
                        rawData = rawData.Concat(data.GetRawData()).ToArray();
                    }

                    ScaledWindow hanning = ScaledWindow.CreateHanningWindow();
                    hanning.Apply(rawData);

                    ComplexDouble[] fft = Transforms.RealFft(rawData);

                    double[] magnitudes = null, phases = null;
                    ComplexDouble.DecomposeArrayPolar(fft, out magnitudes, out phases);

                    int dataLen = magnitudes.Length / 2;
                    double[] fftDraw = new double[dataLen];
                    Array.Copy(magnitudes, 0, fftDraw, 0, fftDraw.Length);

                    double resolution = 1.0 / _Setting.Duration.TotalSeconds;
                    double[] xAxis = new double[dataLen];
                    for (int k = 0; k < dataLen; k++)
                    {
                        xAxis[k] = k * resolution;
                    }

                    _FFTPlots[i].PlotXY(xAxis, fftDraw);
                }

                button1.Enabled = true;
                UpdateResult();
            }
        }

        private void daqTask4474Component1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            daqTask4474Component1.StopTask();
            button1.Enabled = true;
        }

        private void UpdateResult()
        {
            if (textBoxAvg.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    UpdateResult();
                });
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    if (!_EnableChannels[i])
                    {
                        continue;
                    }

                    switch (i)
                    {
                        case 0:
                            textBoxAvg.Text = _Average[i].ToString("F4");
                            textBoxMax.Text = _Maxes[i][0].ToString("F4");
                            textBoxMin.Text = _Mins[i][0].ToString("F4");
                            break;
                        case 1:
                            textBoxAvg2.Text = _Average[i].ToString("F4");
                            textBoxMax2.Text = _Maxes[i][0].ToString("F4");
                            textBoxMin2.Text = _Mins[i][0].ToString("F4");
                            break;
                        default:
                            break;
                    }
                }

                if (_EnableChannels[0] && _EnableChannels[1])
                {
                    textBoxDiffer.Text = (_Average[1] - _Average[0]).ToString("F4");
                }
            }
        }

        private void InitUI()
        {
            textBoxDiffer.Text = "Differ";

            textBoxAvg.Text = "0";
            textBoxMin.Text = "0";
            textBoxMax.Text = "0";

            textBoxAvg2.Text = "0";
            textBoxMin2.Text = "0";
            textBoxMax2.Text = "0";

            waveformGraph1.ClearData();
            waveformGraph2.ClearData();

           // waveformPlot1.XAxis.Range = new Range(DateTime.Now, TimeSpan.FromSeconds(5.5));
        }

        private void InitData()
        {
            _Maxes.Clear();
            _Mins.Clear();
            _Average.Clear();

            _WaveformData.Clear();

            _LastIndex = 0;
            _AveragedCount = 0;
        }

        private void useChannel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            if (menu.Tag.ToString() == "1")
            {
                _EnableChannels[0] = !menu.Checked;
                menu.Checked = _EnableChannels[0];
            }
            else if (menu.Tag.ToString() == "2")
            {
                _EnableChannels[1] = !menu.Checked;
                menu.Checked = _EnableChannels[1];
            }
        }

        private void changeSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordForm pf = new PasswordForm();

            if (pf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SettingForm sf = new SettingForm();
                int i = 0;
                foreach (string device in _Setting.DeviceNames)
                {
                    if (i++ == 0)
                    {
                        sf.DeviceChannel_1 = device;
                    }
                    else
                    {
                        sf.DeviceChannel_2 = device;
                    }
                }

                sf.SamplingRate = _Setting.SampleRate;
                sf.MaxValue = _Setting.MaxValue;
                sf.Duration = _Setting.Duration.TotalSeconds;

                if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _Setting.DeviceNames.Clear();
                    if (sf.DeviceChannel_1.Length > 0)
                    {
                        _Setting.DeviceNames.Add(sf.DeviceChannel_1);
                    }
                    if (sf.DeviceChannel_2.Length > 0)
                    {
                        _Setting.DeviceNames.Add(sf.DeviceChannel_2);
                    }

                    _Setting.SampleRate = sf.SamplingRate;
                    _Setting.MaxValue = sf.MaxValue;
                    _Setting.SamplePerChannel = (int)(_Setting.SampleRate * sf.Duration );/// Fields
                    _Setting.Duration = TimeSpan.FromSeconds(sf.Duration);


                    Properties.Settings.Default.Channel_1 = sf.DeviceChannel_1;
                    Properties.Settings.Default.Channel_2 = sf.DeviceChannel_2;
                    Properties.Settings.Default.SamplingRate = sf.SamplingRate;
                    Properties.Settings.Default.MaxValue = sf.MaxValue;
                    Properties.Settings.Default.Duration = sf.Duration;

                    Properties.Settings.Default.Save();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }
    }
}
