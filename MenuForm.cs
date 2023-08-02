using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace AudioMonitor
{
    public partial class MenuForm : Form
    {
        // Propiedad pública para recibir el valor de seleccionActual
        public string SeleccionRecibida { get; set; }

        public readonly MMDevice[] AudioDevices = new MMDeviceEnumerator()
            .EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active)
            .ToArray();

        public MenuForm()
        {
            InitializeComponent();
            this.Load += MenuForm_Load;
            foreach (MMDevice device in AudioDevices)
            {
                string deviceType = device.DataFlow == DataFlow.Capture ? "INPUT" : "OUTPUT";
                string deviceLabel = $"{deviceType}: {device.FriendlyName}";
                lbDevice.Items.Add(deviceLabel);
            }

            lbDevice.SelectedIndex = 0;
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            // Actualizar el valor del Label con el valor recibido
            nom_estudiante.Text = SeleccionRecibida;
        }

        private WasapiCapture GetSelectedDevice()
        {
            MMDevice selectedDevice = AudioDevices[lbDevice.SelectedIndex];
            return selectedDevice.DataFlow == DataFlow.Render
                ? new WasapiLoopbackCapture(selectedDevice)
                : new WasapiCapture(selectedDevice, true, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WasapiCapture captureDevice = GetSelectedDevice();
            new AudioMonitorForm(captureDevice).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WasapiCapture captureDevice = GetSelectedDevice();
            new FftMonitorForm(captureDevice,SeleccionRecibida).ShowDialog();

           

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
