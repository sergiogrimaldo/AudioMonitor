using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioMonitor
{
    public partial class PanelFinal : Form
    {
        // Propiedad pública para recibir el valor de seleccionActual
        public string SeleccionRecibida { get; set; }

        public PanelFinal()
        {
            InitializeComponent();
            this.Load += PanelFinal_Load;

        }
        private void PanelFinal_Load(object sender, EventArgs e)
        {
            // Actualizar el valor del Label con el valor recibido
            nom_estudiante.Text = SeleccionRecibida;
        }
    }
}
