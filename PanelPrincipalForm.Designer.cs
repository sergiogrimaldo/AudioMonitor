namespace AudioMonitor
{
    partial class PanelPrincipalForm
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
            groupBox1 = new GroupBox();
            listaNombre = new ListBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(listaNombre);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(641, 305);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // listaNombre
            // 
            listaNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listaNombre.FormattingEnabled = true;
            listaNombre.ItemHeight = 21;
            listaNombre.Items.AddRange(new object[] { "Estudiante...", "Orlando Divandoque", "Sebastian Garcés", "Sergio Grimaldos", "Laura López", "Sergio López" });
            listaNombre.Location = new Point(148, 243);
            listaNombre.Name = "listaNombre";
            listaNombre.Size = new Size(261, 25);
            listaNombre.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(438, 243);
            button1.Name = "button1";
            button1.Size = new Size(64, 25);
            button1.TabIndex = 6;
            button1.Text = ">>";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(167, 197);
            label2.Name = "label2";
            label2.Size = new Size(280, 25);
            label2.TabIndex = 8;
            label2.Text = "Por favor, seleccione su nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 144);
            label1.Name = "label1";
            label1.Size = new Size(433, 37);
            label1.TabIndex = 7;
            label1.Text = "Bienvenido al registro de asistencia";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_UNIAGUSTINIANA;
            pictureBox1.Location = new Point(251, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 331);
            Controls.Add(groupBox1);
            Name = "PanelPrincipalForm";
            Text = "PanelPrincipalForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private ListBox listaNombre;
        private Label label2;
    }
}