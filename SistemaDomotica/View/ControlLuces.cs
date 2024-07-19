using System;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;
namespace SistemaDomotica.View
{
    public partial class ControlLuces : Form
    {
        SpeechRecognitionEngine escucha = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-ES"));
        SpeechSynthesizer hablar = new SpeechSynthesizer();
        System.IO.Ports.SerialPort arduino;
        public ControlLuces()
        {
            InitializeComponent();
            hablar.SelectVoice("Microsoft Helena Desktop");
            arduino = new System.IO.Ports.SerialPort();
            arduino.PortName = "COM6";
            arduino.BaudRate = 9600;
            arduino.Open();
        }

        private void ControlLuces_Load(object sender, EventArgs e)
        {

        }

        private void Deteccion(object sender, SpeechRecognizedEventArgs e)
        {
            textBox1.Text = e.Result.Text;

            switch (e.Result.Text)
            {
                case "encender luz dormitorio":
                    arduino.Write("1");
                    hablar.SpeakAsync("Encendiendo la luz del dormitorio");
                    break;

                case "apagar luz dormitorio":
                    arduino.Write("2");
                    hablar.SpeakAsync("Apagando la luz del dormitorio");
                    break;

                case "encender luz comedor":
                    arduino.Write("3");
                    hablar.SpeakAsync("Encendiendo la luz del comedor");
                    break;

                case "apagar luz comedor":
                    arduino.Write("4");
                    hablar.SpeakAsync("Apagando la luz del comedor");
                    break;
                case "encender luz cocina":
                    arduino.Write("5");
                    hablar.SpeakAsync("Encendiendo la luz de la cocina");
                    break;

                case "apagar luz cocina":
                    arduino.Write("6");
                    hablar.SpeakAsync("Apagando la luz de la cocina");
                    break;

                case "encender luz garaje":
                    arduino.Write("7");
                    hablar.SpeakAsync("Encendiendo la luz del garaje");
                    break;

                case "apagar luz garaje":
                    arduino.Write("8");
                    hablar.SpeakAsync("Apagando la luz del garaje");
                    break;
                case "encender luz sala":
                    arduino.Write("9");
                    hablar.SpeakAsync("Encendiendo la luz de la sala");
                    break;

                case "apagar luz sala":
                    arduino.Write("s");
                    hablar.SpeakAsync("Apagando la luz de la sala");
                    break;

                case "encender todas las luces":
                    arduino.Write("t");
                    hablar.SpeakAsync("Encendiendo todas las luces");
                    break;

                case "apagar todas las luces":
                    arduino.Write("a");
                    hablar.SpeakAsync("Apagando todas las luces");
                    break;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arduino.IsOpen)
            {
                arduino.Close();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Configurar reconocimiento de voz
            escucha.SetInputToDefaultAudioDevice();
            escucha.LoadGrammar(new DictationGrammar());
            escucha.SpeechRecognized += Deteccion;
            escucha.RecognizeAsync(RecognizeMode.Multiple);

            Choices alternativas = new Choices();

            alternativas.Add(new string[]
            {
                "encender luz dormitorio", "apagar luz dormitorio",
                "encender luz comedor", "apagar luz comedor",
                "encender luz cocina", "apagar luz cocina",
                "encender luz garaje", "apagar luz garaje",
                "encender luz sala", "apagar luz sala",
                "encender todas las luces", "apagar todas las luces"
            });

            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(alternativas);
            Grammar g = new Grammar(gb);
            escucha.LoadGrammar(g);

            hablar.SpeakAsync("Reconocimiento de voz encendido");
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            escucha.RecognizeAsync();
            hablar.SpeakAsync("Reconocimiento de voz apagado");
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio controlLucesForm = new Inicio();
            controlLucesForm.Show();
            this.Hide();
        }

        private void controlLucesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlLuces controlLucesForm = new ControlLuces();
            controlLucesForm.Show();
            this.Hide();
        }

        private void controlDePuertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlPuertas controlLucesForm = new ControlPuertas();
            controlLucesForm.Show();
            this.Hide();
        }
    }
}
