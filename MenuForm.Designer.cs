namespace AudioMonitor
{
    partial class MenuForm
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
            btnLaunchWaveform = new Button();
            btnLaunchFFT = new Button();
            lbDevice = new ListBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLaunchWaveform
            // 
            btnLaunchWaveform.Location = new Point(59, 217);
            btnLaunchWaveform.Name = "btnLaunchWaveform";
            btnLaunchWaveform.Size = new Size(117, 54);
            btnLaunchWaveform.TabIndex = 0;
            btnLaunchWaveform.Text = "Audio Waveform";
            btnLaunchWaveform.UseVisualStyleBackColor = true;
            btnLaunchWaveform.Click += button1_Click;
            // 
            // btnLaunchFFT
            // 
            btnLaunchFFT.Location = new Point(211, 217);
            btnLaunchFFT.Name = "btnLaunchFFT";
            btnLaunchFFT.Size = new Size(117, 54);
            btnLaunchFFT.TabIndex = 1;
            btnLaunchFFT.Text = "Audio FFT";
            btnLaunchFFT.UseVisualStyleBackColor = true;
            btnLaunchFFT.Click += button2_Click;
            // 
            // lbDevice
            // 
            lbDevice.Dock = DockStyle.Fill;
            lbDevice.FormattingEnabled = true;
            lbDevice.ItemHeight = 15;
            lbDevice.Location = new Point(3, 19);
            lbDevice.Name = "lbDevice";
            lbDevice.Size = new Size(394, 112);
            lbDevice.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lbDevice);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 134);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecciona la entrada de sonido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Estudiante: ";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 299);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnLaunchFFT);
            Controls.Add(btnLaunchWaveform);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLaunchWaveform;
        private Button btnLaunchFFT;
        private ListBox lbDevice;
        private GroupBox groupBox1;
        private Label label1;
    }
}