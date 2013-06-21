using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NationalInstruments.DAQmx;

namespace DaqApplication
{
    public partial class SettingForm : Form
    {
        public string DeviceChannel_1 { get; set; }
        public string DeviceChannel_2 { get; set; }
        public double SamplingRate { get; set; }
        public double Duration { get; set; }
        public double MaxValue { get; set; }

        public SettingForm()
        {
            InitializeComponent();

            DeviceChannel_1 = "";
            DeviceChannel_2 = "";
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            //string[] channels = DaqSystem.Local.GetPhysicalChannels( PhysicalChannelTypes.AI, PhysicalChannelAccess.All);
            string[] devices = DaqSystem.Local.Devices;
            foreach (string item in devices)
            {
                Device dev = DaqSystem.Local.LoadDevice(item);

                string devType = dev.ProductType;
                if (devType.Contains("4474"))
                {
                    string[] channels = dev.AIPhysicalChannels;
                    comboBoxChannel1.Items.AddRange(channels);
                    comboBoxChannel2.Items.AddRange(channels);
                }
            }

            if (comboBoxChannel1.Items.Contains(DeviceChannel_1))
            {
                comboBoxChannel1.SelectedIndex = comboBoxChannel1.Items.IndexOf(DeviceChannel_1);
            }
            if (comboBoxChannel2.Items.Contains(DeviceChannel_2))
            {
                comboBoxChannel2.SelectedIndex = comboBoxChannel2.Items.IndexOf(DeviceChannel_2);
            }

            numericEditMax.Value = MaxValue;
            numericEditDuration.Value = Duration;
            maskedTextBoxRate.Text = SamplingRate.ToString("F0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeviceChannel_1 = comboBoxChannel1.Text;
            DeviceChannel_2 = comboBoxChannel2.Text;
            Duration = numericEditDuration.Value;
            MaxValue = numericEditMax.Value;

            try
            {
                SamplingRate = Double.Parse(maskedTextBoxRate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Sampling Rate can only be filled with digits, pls confirm! \n\n" + 
                    ex.ToString());

                return;
            }

            if (DeviceChannel_1.Length < 1 || DeviceChannel_2.Length < 1)
            {
                MessageBox.Show("Pls choose both device channels!");

                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}
