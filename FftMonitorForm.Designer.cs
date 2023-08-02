namespace AudioMonitor
{
    partial class FftMonitorForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnInicia = new Button();
            formsPlot1 = new ScottPlot.FormsPlot();
            ptHist = new ScottPlot.FormsPlot();
            dgFreq = new DataGridView();
            dgData = new DataGridView();
            lbltexto = new Label();
            ((System.ComponentModel.ISupportInitialize)dgFreq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 6;
            label1.Text = "Peak Frequency:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // btnInicia
            // 
            btnInicia.BackColor = Color.Green;
            btnInicia.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicia.ForeColor = Color.White;
            btnInicia.Location = new Point(134, 234);
            btnInicia.Name = "btnInicia";
            btnInicia.Size = new Size(211, 85);
            btnInicia.TabIndex = 10;
            btnInicia.Text = "INICIA";
            btnInicia.UseVisualStyleBackColor = false;
            btnInicia.Click += btnInicia_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formsPlot1.Location = new Point(12, 27);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(448, 212);
            formsPlot1.TabIndex = 9;
            // 
            // ptHist
            // 
            ptHist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ptHist.Location = new Point(6, 292);
            ptHist.Margin = new Padding(4, 3, 4, 3);
            ptHist.Name = "ptHist";
            ptHist.Size = new Size(0, 175);
            ptHist.TabIndex = 15;
            ptHist.Visible = false;
            // 
            // dgFreq
            // 
            dgFreq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFreq.Location = new Point(478, 251);
            dgFreq.Name = "dgFreq";
            dgFreq.RowTemplate.Height = 25;
            dgFreq.Size = new Size(341, 157);
            dgFreq.TabIndex = 14;
            dgFreq.Visible = false;
            // 
            // dgData
            // 
            dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgData.Location = new Point(478, 62);
            dgData.Name = "dgData";
            dgData.RowTemplate.Height = 25;
            dgData.Size = new Size(341, 157);
            dgData.TabIndex = 13;
            dgData.Visible = false;
            // 
            // lbltexto
            // 
            lbltexto.AutoSize = true;
            lbltexto.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            lbltexto.Location = new Point(39, 353);
            lbltexto.Name = "lbltexto";
            lbltexto.Size = new Size(361, 59);
            lbltexto.TabIndex = 16;
            lbltexto.Text = "                            ";
            // 
            // FftMonitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 464);
            Controls.Add(lbltexto);
            Controls.Add(ptHist);
            Controls.Add(dgFreq);
            Controls.Add(dgData);
            Controls.Add(btnInicia);
            Controls.Add(formsPlot1);
            Controls.Add(label1);
            Name = "FftMonitorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FFT Monitor";
            ((System.ComponentModel.ISupportInitialize)dgFreq).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button btnInicia;
        private ScottPlot.FormsPlot formsPlot1;
        private ScottPlot.FormsPlot ptHist;
        private DataGridView dgFreq;
        private DataGridView dgData;
        private Label lbltexto;
    }
}