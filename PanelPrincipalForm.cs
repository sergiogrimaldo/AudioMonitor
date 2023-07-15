using System;
using System.Windows.Forms;


namespace AudioMonitor
{
    public partial class PanelPrincipalForm : Form
    {
        // Declarar una variable para almacenar la selección actual
        string seleccionActual = "";
        public PanelPrincipalForm()
        {
            InitializeComponent();

            // Agregar los valores al ListBox
            listaNombre.Items.Add("Estudiante");
            listaNombre.Items.Add("Orlando Gomez");
            listaNombre.Items.Add("Laura Lopez");
            listaNombre.Items.Add("Sergio Grimaldo");
            listaNombre.Items.Add("Sergio Lopez");
            listaNombre.Items.Add("Sebastian Garcés");

            // Establecer "Estudiante" como el valor por defecto
            listaNombre.SelectedIndex = 0;
            BtnEnter.Enabled = false;

            //// Cambiar el estilo del ListBox a DropDownList
            //listaNombre.DropDownStyle = ComboBoxStyle.DropDown;


            // Suscribir el evento SelectedIndexChanged del ListBox
            listaNombre.SelectedIndexChanged += ListaNombre_SelectedIndexChanged;
        }
        ////
        ///
        // Evento SelectedIndexChanged del ListBox
        private void ListaNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado del ListBox
            seleccionActual = listaNombre.SelectedItem.ToString();



            // Verificar si la selección es diferente de "Estudiante"
            if (seleccionActual != "Estudiante")
            {
                // Habilitar el botón BtnEnter
                BtnEnter.Enabled = true;
            }
            else
            {

                // Deshabilitar el botón BtnEnter si se selecciona "Estudiante"
                BtnEnter.Enabled = false;

            }

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {

            // Crear una instancia del formulario MenuForm
            MenuForm menuForm = new MenuForm();

            // Mostrar el formulario MenuForm
            menuForm.Show();

            // Cerrar el formulario actual
            this.Hide();
            this.Dispose();
        }
    }
}
