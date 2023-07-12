using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioMonitor
{
    public partial class IdentificacionPanelForm : Form
    {
        public IdentificacionPanelForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
public string TextoEtiqueta
        {

            get { return label3.Text; }

            set { label3.Text = value; }

        }

    }
}
