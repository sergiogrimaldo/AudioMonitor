using NAudio.CoreAudioApi;
using NAudio.Wave;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using AuditorInfraestructure.Entities.AuditorInfraestructure;

namespace AudioMonitor;

public partial class FftMonitorForm : Form
{
    //Variable del dbcontest
    private ProyectoContext db;

    readonly double[] AudioValues;

    readonly WasapiCapture AudioDevice;
    readonly String SeleccionNombre;
    readonly double[] FftValues;
    readonly double[] FftUso;


    public bool bActivo { get; private set; }
    private string sMuestra;

    private List<JObject> dtCaptura;

    private List<JObject> dtFreq;

    private BindingSource srf;

    private double periodo;
    public FftMonitorForm(WasapiCapture audioDevice, String NombreEstudiante)
    {
        InitializeComponent();
        db = new ProyectoContext();

        AudioDevice = audioDevice;
        WaveFormat fmt = audioDevice.WaveFormat;
        SeleccionNombre = NombreEstudiante;

        bActivo = false;

        AudioValues = new double[fmt.SampleRate / 10];
        double[] paddedAudio = FftSharp.Pad.ZeroPad(AudioValues);
        double[] fftMag = FftSharp.Transform.FFTpower(paddedAudio);
        FftValues = new double[fftMag.Length];
        FftUso = new double[fftMag.Length];
        double fftPeriod = FftSharp.Transform.FFTfreqPeriod(fmt.SampleRate, fftMag.Length);

        formsPlot1.Plot.AddSignal(FftValues, 1.0 / fftPeriod);
        formsPlot1.Plot.YLabel("Potencia");
        formsPlot1.Plot.XLabel("Frecuencia (kHz)");
        formsPlot1.Plot.Title($"{fmt.Encoding} ({fmt.BitsPerSample}-bit) {fmt.SampleRate} KHz");
        formsPlot1.Plot.SetAxisLimits(0, 2000, 0, .01);
        formsPlot1.Refresh();

        for (int i = 0; i < FftUso.Length; i++)
        {
            FftUso[i] = 7;
        }

        ptHist.Plot.AddBar(FftUso);
        ptHist.Plot.YLabel("Uso");
        ptHist.Plot.XLabel("Frecuencia (kHz)");
        ptHist.Plot.Title($"Historial");
        ptHist.Plot.SetAxisLimits(0, 2000, 0, 10);
        ptHist.Refresh();

        AudioDevice.DataAvailable += WaveIn_DataAvailable;
        AudioDevice.StartRecording();

        FormClosed += FftMonitorForm_FormClosed;
        dtCaptura = new List<JObject>();
        dtFreq = new List<JObject>();
        dtCaptura.Add(
            JObject.FromObject(
                new
                {
                    Dato1 = "Ejemplo",
                    Valor1 = 3423423
                }
                )
            );

        var sr = new BindingSource();
        sr.DataSource = dtCaptura;
        dgData.DataSource = sr;

        dtFreq.Add(
    JObject.FromObject(
        new
        {
            Dato1 = "Sample",
            Valor1 = 192929
        }
        )
    );
        srf = new BindingSource();

        var rd = dtFreq.OrderByDescending(x => x["ix"]?.Value<int>()).ToList();
        srf.DataSource = rd;
        dgFreq.DataSource = srf;
    }

    private async void CambiarEstado()
    {

        bActivo = !bActivo;
        if (bActivo)
        {
            btnInicia.BackColor = Color.Red;
            btnInicia.Text = "DETENER";
            dtCaptura.Clear();
            dtFreq.Clear();
            int i = 0;
            for (i = 0; i < FftUso.Length; i++)
            {
                FftUso[i] = 0;
            }
        }
        else
        {
            double probabilidad = GenerarProbabilidadAleatoria();
            btnInicia.BackColor = Color.Green;
            btnInicia.Text = "INICIA";
            var sr = new BindingSource();
            sr.DataSource = dtCaptura;
            dgData.DataSource = sr;
            dgData.Refresh();

            int mn = 0;
            int mx = 0;
            for (int i = 0; i < FftUso.Length; i++)
            {
                if (FftUso[i] == 1 && FftUso.Max() >= 2)
                {
                    FftUso[i] = 0;
                    dtFreq = dtFreq.Where(x => x["ix"]?.Value<int>() != i).Select(x => x).ToList();
                }
                if (FftUso[i] == FftUso.Max())
                {
                    mn = i - 50;
                    mn = mn < 0 ? 0 : mn;
                    mx = i + 50;
                }
            }

            srf = new BindingSource();
            var rd = dtFreq.OrderByDescending(x => x["ix"]?.Value<double>()).ToList();
            srf.DataSource = rd;
            dgFreq.DataSource = srf;
            dgFreq.Refresh();
            var dato = rd.First()["ix"].Value<int>() * periodo;
            ptHist.Plot.SetAxisLimits(/*mn*/0, dtFreq.Where(x => x["ix"]?.Value<double>() > 0).Max(x => x["ix"]?.Value<double>()) /*mx*/, 0, FftUso.Max());

            ptHist.Refresh();

            if (Validar(SeleccionNombre, dato))
            {
                lbltexto.Text = "Validado";

                // Espera 5 segundos y luego oculta el formulario
                await Task.Delay(2000);

                this.Hide();

                // Crear una instancia del formulario MenuForm
                PanelFinal menuForm = new PanelFinal();

                // Establecer el valor de seleccionActual en la propiedad SeleccionRecibida del formulario 
                menuForm.SeleccionRecibida = SeleccionNombre;

                // Mostrar el formulario MenuForm
                menuForm.Show();
            }
            else
            {
                lbltexto.Text = "Repitalo de nuevo";
            }
        }
    }


    private double GenerarProbabilidadAleatoria()
    {
        Random random = new Random();
        return random.NextDouble() * 100;
    }

    private void FftMonitorForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        System.Diagnostics.Debug.WriteLine($"Closing audio device: {AudioDevice}");
        AudioDevice.StopRecording();
        AudioDevice.Dispose();
    }

    private void WaveIn_DataAvailable(object? sender, WaveInEventArgs e)
    {
        int bytesPerSamplePerChannel = AudioDevice.WaveFormat.BitsPerSample / 8;
        int bytesPerSample = bytesPerSamplePerChannel * AudioDevice.WaveFormat.Channels;
        int bufferSampleCount = e.Buffer.Length / bytesPerSample;

        if (bufferSampleCount >= AudioValues.Length)
        {
            bufferSampleCount = AudioValues.Length;
        }

        if (bytesPerSamplePerChannel == 2 && AudioDevice.WaveFormat.Encoding == WaveFormatEncoding.Pcm)
        {
            for (int i = 0; i < bufferSampleCount; i++)
                AudioValues[i] = BitConverter.ToInt16(e.Buffer, i * bytesPerSample);
        }
        else if (bytesPerSamplePerChannel == 4 && AudioDevice.WaveFormat.Encoding == WaveFormatEncoding.Pcm)
        {
            for (int i = 0; i < bufferSampleCount; i++)
                AudioValues[i] = BitConverter.ToInt32(e.Buffer, i * bytesPerSample);
        }
        else if (bytesPerSamplePerChannel == 4 && AudioDevice.WaveFormat.Encoding == WaveFormatEncoding.IeeeFloat)
        {
            for (int i = 0; i < bufferSampleCount; i++)
                AudioValues[i] = BitConverter.ToSingle(e.Buffer, i * bytesPerSample);
        }
        else
        {
            throw new NotSupportedException(AudioDevice.WaveFormat.ToString());
        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        double[] paddedAudio = FftSharp.Pad.ZeroPad(AudioValues);
        double[] fftMag = FftSharp.Transform.FFTmagnitude(paddedAudio);
        Array.Copy(fftMag, FftValues, fftMag.Length);

        // find the frequency peak
        int peakIndex = 0;
        string test = "";
        for (int i = 0; i < fftMag.Length; i++)
        {
            if (fftMag[i] > fftMag[peakIndex])
                peakIndex = i;
        }
        double fftPeriod = FftSharp.Transform.FFTfreqPeriod(AudioDevice.WaveFormat.SampleRate, fftMag.Length);
        double peakFrequency = fftPeriod * peakIndex;
        periodo = fftPeriod;
        label1.Text = $"Peak Frequency: {peakFrequency:N0} Hz";


        // request a redraw using a non-blocking render queue
        formsPlot1.RefreshRequest();

        if (bActivo)
        {
            int j = 0;
            test = string.Join(";", fftMag.Select(x => Math.Round(x, 10).ToString()).ToArray());
            JObject jo = new JObject();
            Func<double, int, double> fd = (a, b) => { if (b < 20) jo["rango" + b] = a; return b; };

            var z = fftMag.Select(x => fd(x, j++)).ToList();
            dtCaptura.Add(jo);
            dtFreq.Add(JObject.FromObject(new { fq = peakFrequency, ix = peakIndex, pw = fftMag[peakIndex] }));
            FftUso[peakIndex] = ((int)FftUso[peakIndex]) + 1;
        }

    }

    private void btnInicia_Click(object sender, EventArgs e)
    {
        CambiarEstado();
    }

    private void FftMonitorForm_Load(object sender, EventArgs e)
    {

    }

    private bool Validar(string nombre, double frecuencia)
    {
        //Consultar a la base de datos a la información que tenga de esa persona
        var sql_consulta_nombre = $"SELECT ID FROM ESTUDIANTES WHERE Nombre = {SeleccionNombre}";
        var estudiante = db.Estudiantes.Where(x => x.Nombre == nombre).First();

        //Frecuencia persona
        //Comparar contra la variable frecuencia
        var resultado = Comparacion((float) estudiante.Registro1, (float) estudiante.Registro2, (float) estudiante.Registro3, (float) frecuencia);
        if (resultado != 0)
        {
            if (resultado < estudiante.Registro1)
            {
                estudiante.Registro1 = resultado;
            }
            else
            {
                if (resultado > estudiante.Registro3)
                {
                    estudiante.Registro3 = resultado;
                }
                else
                {
                    estudiante.Registro2 = resultado;
                }
            }
            db.SaveChanges();
            db.Asistencias.Add(new Asistencia { 
                IdEstudiante = estudiante.Id,
                Fecha = DateTime.Now,
                Registro = frecuencia,
                Exitoso = true
            });
            db.SaveChanges();
            return true;
        }
        
        db.Asistencias.Add(new Asistencia
        {
            IdEstudiante = estudiante.Id,
            Fecha = DateTime.Now,
            Registro = frecuencia,
            Exitoso = false
        });
        db.SaveChanges();
        return false;
    }
    private float Comparacion(float registro1, float registro2, float registro3, float entrada, float porcentaje = 0.1f)
    {
        var media = (registro1 + registro2 + registro3) / 3;
        var resta_absoluta = Math.Abs(media - entrada);
        var minimo = registro1 - (registro3 - registro1)*porcentaje;
        var maximo = registro3 + (registro3 - registro1) * porcentaje;
        if (entrada>minimo && entrada<maximo)
        {
            return entrada;
        }

        return 0f;
    }
}
