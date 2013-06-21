namespace DaqApplication
{
    partial class SettingForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxChannel1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxRate = new System.Windows.Forms.MaskedTextBox();
            this.gauge1 = new NationalInstruments.UI.WindowsForms.Gauge();
            this.meter1 = new NationalInstruments.UI.WindowsForms.Meter();
            this.numericEditDuration = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numericEditMax = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxChannel2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(52, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device Channel 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sampling Rate:";
            // 
            // comboBoxChannel1
            // 
            this.comboBoxChannel1.FormattingEnabled = true;
            this.comboBoxChannel1.Location = new System.Drawing.Point(161, 31);
            this.comboBoxChannel1.Name = "comboBoxChannel1";
            this.comboBoxChannel1.Size = new System.Drawing.Size(156, 21);
            this.comboBoxChannel1.TabIndex = 6;
            // 
            // maskedTextBoxRate
            // 
            this.maskedTextBoxRate.Location = new System.Drawing.Point(161, 109);
            this.maskedTextBoxRate.Mask = "999999999999";
            this.maskedTextBoxRate.Name = "maskedTextBoxRate";
            this.maskedTextBoxRate.Size = new System.Drawing.Size(156, 20);
            this.maskedTextBoxRate.TabIndex = 7;
            this.maskedTextBoxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gauge1
            // 
            this.gauge1.Caption = "Sampling Duration (s)";
            this.gauge1.CaptionBackColor = System.Drawing.Color.Silver;
            this.gauge1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge1.CaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.gauge1.EditRangeNumericFormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode();
            this.gauge1.InteractionMode = ((NationalInstruments.UI.RadialNumericPointerInteractionModes)((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer)));
            this.gauge1.Location = new System.Drawing.Point(23, 202);
            this.gauge1.Name = "gauge1";
            this.gauge1.Range = new NationalInstruments.UI.Range(0D, 20D);
            this.gauge1.Size = new System.Drawing.Size(194, 183);
            this.gauge1.TabIndex = 9;
            // 
            // meter1
            // 
            this.meter1.Caption = "Max Value";
            this.meter1.CaptionBackColor = System.Drawing.Color.Silver;
            this.meter1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meter1.CaptionForeColor = System.Drawing.Color.Black;
            this.meter1.Enabled = false;
            this.meter1.InteractionMode = ((NationalInstruments.UI.RadialNumericPointerInteractionModes)((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer)));
            this.meter1.Location = new System.Drawing.Point(258, 202);
            this.meter1.MeterStyle = NationalInstruments.UI.MeterStyle.FlatWithThinNeedle;
            this.meter1.Name = "meter1";
            this.meter1.ScaleArc = new NationalInstruments.UI.Arc(165F, -150F);
            this.meter1.Size = new System.Drawing.Size(194, 183);
            this.meter1.TabIndex = 11;
            // 
            // numericEditDuration
            // 
            this.numericEditDuration.Location = new System.Drawing.Point(59, 401);
            this.numericEditDuration.Name = "numericEditDuration";
            this.numericEditDuration.Size = new System.Drawing.Size(120, 20);
            this.numericEditDuration.Source = this.gauge1;
            this.numericEditDuration.TabIndex = 12;
            // 
            // numericEditMax
            // 
            this.numericEditMax.Enabled = false;
            this.numericEditMax.Location = new System.Drawing.Point(301, 401);
            this.numericEditMax.Name = "numericEditMax";
            this.numericEditMax.Size = new System.Drawing.Size(120, 20);
            this.numericEditMax.Source = this.meter1;
            this.numericEditMax.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Device Channel 2:";
            // 
            // comboBoxChannel2
            // 
            this.comboBoxChannel2.FormattingEnabled = true;
            this.comboBoxChannel2.Location = new System.Drawing.Point(161, 67);
            this.comboBoxChannel2.Name = "comboBoxChannel2";
            this.comboBoxChannel2.Size = new System.Drawing.Size(156, 21);
            this.comboBoxChannel2.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxRate);
            this.groupBox1.Controls.Add(this.comboBoxChannel2);
            this.groupBox1.Controls.Add(this.comboBoxChannel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 153);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hz";
            // 
            // SettingForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericEditMax);
            this.Controls.Add(this.numericEditDuration);
            this.Controls.Add(this.meter1);
            this.Controls.Add(this.gauge1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingForm";
            this.Text = "Setting  Form";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxChannel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRate;
        private NationalInstruments.UI.WindowsForms.Gauge gauge1;
        private NationalInstruments.UI.WindowsForms.Meter meter1;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEditDuration;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEditMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxChannel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}