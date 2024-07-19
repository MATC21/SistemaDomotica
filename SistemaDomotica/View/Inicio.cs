using System;
using System.Windows.Forms;

namespace SistemaDomotica.View
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void controlLucesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlLuces controlLucesForm = new ControlLuces();
            controlLucesForm.Show();
            this.Hide();
        }

        private void controlDePuertasToolStripMenuItem_CliAck(object sender, EventArgs e)
        {
            ControlPuertas controlLucesForm = new ControlPuertas();
            controlLucesForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio controlLucesForm = new Inicio();
            controlLucesForm.Show();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void controlDePuertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlPuertas controlLucesForm = new ControlPuertas();
            controlLucesForm.Show();
            this.Hide();
        }
    }
}
