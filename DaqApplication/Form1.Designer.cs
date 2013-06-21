namespace DaqApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.waveformGraph2 = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.waveformPlotFft1 = new NationalInstruments.UI.ScatterPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.waveformPlotFft2 = new NationalInstruments.UI.ScatterPlot();
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.waveformPlotReal1 = new NationalInstruments.UI.ScatterPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.waveformPlotReal2 = new NationalInstruments.UI.ScatterPlot();
            this.button1 = new System.Windows.Forms.Button();
            this.daqTask4474Component1 = new DaqApplication.DaqTask4474Component(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxAvg = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deviceSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useChannel1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useChannel2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAvg2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMax2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMin2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDiffer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daqTask4474Component1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.waveformGraph2);
            this.panel1.Controls.Add(this.waveformGraph1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 589);
            this.panel1.TabIndex = 0;
            // 
            // waveformGraph2
            // 
            this.waveformGraph2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformGraph2.Caption = "FFT";
            this.waveformGraph2.Location = new System.Drawing.Point(2, 335);
            this.waveformGraph2.Name = "waveformGraph2";
            this.waveformGraph2.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.waveformPlotFft1,
            this.waveformPlotFft2});
            this.waveformGraph2.Size = new System.Drawing.Size(684, 251);
            this.waveformGraph2.TabIndex = 2;
            this.waveformGraph2.UseColorGenerator = true;
            this.waveformGraph2.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.waveformGraph2.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            // 
            // waveformPlotFft1
            // 
            this.waveformPlotFft1.XAxis = this.xAxis2;
            this.waveformPlotFft1.YAxis = this.yAxis2;
            // 
            // xAxis2
            // 
            this.xAxis2.Caption = "Freq (Hz)";
            // 
            // waveformPlotFft2
            // 
            this.waveformPlotFft2.XAxis = this.xAxis2;
            this.waveformPlotFft2.YAxis = this.yAxis2;
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformGraph1.Caption = "Real Data";
            this.waveformGraph1.Location = new System.Drawing.Point(2, 2);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.waveformPlotReal1,
            this.waveformPlotReal2});
            this.waveformGraph1.Size = new System.Drawing.Size(685, 327);
            this.waveformGraph1.TabIndex = 1;
            this.waveformGraph1.UseColorGenerator = true;
            this.waveformGraph1.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph1.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlotReal1
            // 
            this.waveformPlotReal1.HistoryCapacity = 200000;
            this.waveformPlotReal1.XAxis = this.xAxis1;
            this.waveformPlotReal1.YAxis = this.yAxis1;
            // 
            // xAxis1
            // 
            this.xAxis1.Caption = "Time (s)";
            this.xAxis1.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "F3");
            // 
            // waveformPlotReal2
            // 
            this.waveformPlotReal2.HistoryCapacity = 200000;
            this.waveformPlotReal2.XAxis = this.xAxis1;
            this.waveformPlotReal2.YAxis = this.yAxis1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(716, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // daqTask4474Component1
            // 
            this.daqTask4474Component1.DeviceNames = null;
            this.daqTask4474Component1.Max = 0D;
            this.daqTask4474Component1.Rate = 0D;
            this.daqTask4474Component1.SamplePerChannel = 0;
            this.daqTask4474Component1.ReadCompleted += new System.EventHandler<DaqApplication.DaqTask4474ComponentReadCompletedEventArgs>(this.daqTask4474Component1_ReadCompleted);
            this.daqTask4474Component1.Error += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs>(this.daqTask4474Component1_Error);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Average :";
            // 
            // textBoxMin
            // 
            this.textBoxMin.BackColor = System.Drawing.Color.White;
            this.textBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxMin.Location = new System.Drawing.Point(63, 40);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMin.TabIndex = 4;
            this.textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMax
            // 
            this.textBoxMax.BackColor = System.Drawing.Color.White;
            this.textBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxMax.Location = new System.Drawing.Point(63, 75);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 4;
            this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAvg
            // 
            this.textBoxAvg.BackColor = System.Drawing.Color.White;
            this.textBoxAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxAvg.Location = new System.Drawing.Point(63, 114);
            this.textBoxAvg.Name = "textBoxAvg";
            this.textBoxAvg.ReadOnly = true;
            this.textBoxAvg.Size = new System.Drawing.Size(100, 20);
            this.textBoxAvg.TabIndex = 4;
            this.textBoxAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceSettingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deviceSettingToolStripMenuItem
            // 
            this.deviceSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useChannel1ToolStripMenuItem,
            this.useChannel2ToolStripMenuItem,
            this.changeSettingToolStripMenuItem});
            this.deviceSettingToolStripMenuItem.Name = "deviceSettingToolStripMenuItem";
            this.deviceSettingToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.deviceSettingToolStripMenuItem.Text = "Device Setting";
            // 
            // useChannel1ToolStripMenuItem
            // 
            this.useChannel1ToolStripMenuItem.Checked = true;
            this.useChannel1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useChannel1ToolStripMenuItem.Name = "useChannel1ToolStripMenuItem";
            this.useChannel1ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.useChannel1ToolStripMenuItem.Tag = "1";
            this.useChannel1ToolStripMenuItem.Text = "Use Channel 1";
            this.useChannel1ToolStripMenuItem.Click += new System.EventHandler(this.useChannel1ToolStripMenuItem_Click);
            // 
            // useChannel2ToolStripMenuItem
            // 
            this.useChannel2ToolStripMenuItem.Name = "useChannel2ToolStripMenuItem";
            this.useChannel2ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.useChannel2ToolStripMenuItem.Tag = "2";
            this.useChannel2ToolStripMenuItem.Text = "Use Channel 2";
            this.useChannel2ToolStripMenuItem.Click += new System.EventHandler(this.useChannel1ToolStripMenuItem_Click);
            // 
            // changeSettingToolStripMenuItem
            // 
            this.changeSettingToolStripMenuItem.Name = "changeSettingToolStripMenuItem";
            this.changeSettingToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.changeSettingToolStripMenuItem.Text = "Change Setting";
            this.changeSettingToolStripMenuItem.Click += new System.EventHandler(this.changeSettingToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.textBoxAvg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(705, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 163);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysis_1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.textBoxAvg2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxMax2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxMin2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(705, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 163);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analysis_2";
            // 
            // textBoxAvg2
            // 
            this.textBoxAvg2.BackColor = System.Drawing.Color.White;
            this.textBoxAvg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvg2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxAvg2.Location = new System.Drawing.Point(63, 114);
            this.textBoxAvg2.Name = "textBoxAvg2";
            this.textBoxAvg2.ReadOnly = true;
            this.textBoxAvg2.Size = new System.Drawing.Size(100, 20);
            this.textBoxAvg2.TabIndex = 4;
            this.textBoxAvg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Min :";
            // 
            // textBoxMax2
            // 
            this.textBoxMax2.BackColor = System.Drawing.Color.White;
            this.textBoxMax2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMax2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxMax2.Location = new System.Drawing.Point(63, 75);
            this.textBoxMax2.Name = "textBoxMax2";
            this.textBoxMax2.ReadOnly = true;
            this.textBoxMax2.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax2.TabIndex = 4;
            this.textBoxMax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Max :";
            // 
            // textBoxMin2
            // 
            this.textBoxMin2.BackColor = System.Drawing.Color.White;
            this.textBoxMin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMin2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxMin2.Location = new System.Drawing.Point(63, 40);
            this.textBoxMin2.Name = "textBoxMin2";
            this.textBoxMin2.ReadOnly = true;
            this.textBoxMin2.Size = new System.Drawing.Size(100, 20);
            this.textBoxMin2.TabIndex = 4;
            this.textBoxMin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Average :";
            // 
            // textBoxDiffer
            // 
            this.textBoxDiffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDiffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiffer.ForeColor = System.Drawing.Color.Blue;
            this.textBoxDiffer.Location = new System.Drawing.Point(716, 516);
            this.textBoxDiffer.Name = "textBoxDiffer";
            this.textBoxDiffer.ReadOnly = true;
            this.textBoxDiffer.Size = new System.Drawing.Size(155, 22);
            this.textBoxDiffer.TabIndex = 7;
            this.textBoxDiffer.Text = "Differ";
            this.textBoxDiffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(702, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Difference of two channels:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 628);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDiffer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Blade Dynamic Measurement";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daqTask4474Component1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DaqTask4474Component daqTask4474Component1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private NationalInstruments.UI.WindowsForms.ScatterGraph waveformGraph1;
        private NationalInstruments.UI.ScatterPlot waveformPlotReal1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxAvg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deviceSettingToolStripMenuItem;
        private NationalInstruments.UI.WindowsForms.ScatterGraph waveformGraph2;
        private NationalInstruments.UI.ScatterPlot waveformPlotFft1;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxAvg2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMax2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMin2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDiffer;
        private NationalInstruments.UI.ScatterPlot waveformPlotFft2;
        private NationalInstruments.UI.ScatterPlot waveformPlotReal2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem useChannel1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useChannel2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}

