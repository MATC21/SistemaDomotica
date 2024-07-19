//using SistemaDomotica.View.PartialView;
using System;
using System.Windows.Forms;

namespace SistemaDomotica.View
{
    public partial class ControlPuertas : Form
    {
        public ControlPuertas()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //frmReconocedorF controlLucesForm = new frmReconocedorF();
            //controlLucesForm.Show();
            //this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //RegistrarUsuario controlLucesForm = new RegistrarUsuario();
            //controlLucesForm.Show();
            //this.Hide();
        }
    }
}
