namespace AudioMonitor
{
    public partial class PanelPrincipalForm : Form
    {
        public PanelPrincipalForm()
        {
            InitializeComponent();
        }

        private void EnviarDatoAlOtroFormulario()
        {
            // Obtener el formulario de destino
            IdentificacionPanelForm otroFormulario = new IdentificacionPanelForm();



            // Obtener el dato seleccionado del ListBox
            string datoSeleccionado = listaNombre.SelectedItem.ToString();



            // Establecer el valor de la propiedad en el formulario de destino
            otroFormulario.TextoEtiqueta = datoSeleccionado;



            // Mostrar el formulario de destino
            otroFormulario.Show();
        }
    }
}
