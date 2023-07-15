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


            /// <summary>
            /// 
            /// </summary>
            //public void EnviarDatoAlOtroFormulario()
            //{
            //    Obtener el formulario de destino
            //   IdentificacionPanelForm otroFormulario = new IdentificacionPanelForm();

            //    Obtener el dato seleccionado del ListBox
            //    string datoSeleccionado = listaNombre.SelectedItem.ToString();

            //    Establecer el valor de la propiedad en el formulario de destino
            //    otroFormulario.TextoEtiqueta = datoSeleccionado;

            //    Mostrar el formulario de destino
            //    otroFormulario.Show();
            //}
        }
    }
}
