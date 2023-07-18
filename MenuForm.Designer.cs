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
            textBox1 = new TextBox();
            label2 = new Label();
            nom_estudiante = new Label();
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
            lbDevice.Size = new Size(187, 123);
            lbDevice.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lbDevice);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 145);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecciona la entrada de sonido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 5;
            label1.Text = "Estudiante: ";
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(211, 85);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 53);
            textBox1.TabIndex = 7;
            textBox1.Text = "Por favor, repita la siguiente palabra cuando inicie la grabación:";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(247, 152);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 8;
            label2.Text = "Asistencia";
            // 
            // nom_estudiante
            // 
            nom_estudiante.AutoSize = true;
            nom_estudiante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nom_estudiante.Location = new Point(110, 25);
            nom_estudiante.Name = "nom_estudiante";
            nom_estudiante.Size = new Size(0, 21);
            nom_estudiante.TabIndex = 9;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 299);
            Controls.Add(nom_estudiante);
            Controls.Add(label2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label2;
        private Label nom_estudiante;
    }
}