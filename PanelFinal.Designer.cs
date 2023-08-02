namespace AudioMonitor
{
    partial class PanelFinal
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
            label1 = new Label();
            nom_estudiante = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(514, 59);
            label1.TabIndex = 0;
            label1.Text = "GRACIAS POR VALIDARSE";
            // 
            // nom_estudiante
            // 
            nom_estudiante.AutoSize = true;
            nom_estudiante.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nom_estudiante.Location = new Point(196, 144);
            nom_estudiante.Name = "nom_estudiante";
            nom_estudiante.Size = new Size(206, 37);
            nom_estudiante.TabIndex = 1;
            nom_estudiante.Text = "                           ";
            // 
            // PanelFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 276);
            Controls.Add(nom_estudiante);
            Controls.Add(label1);
            Name = "PanelFinal";
            Text = "PanelFinal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label nom_estudiante;
    }
}