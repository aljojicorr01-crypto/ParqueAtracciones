using ParqueAtracciones.Controlador;
using ParqueAtracciones.Entidades;
using System;
using System.Windows.Forms;

namespace ParqueAtracciones.Formulario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAtracciones frm = new frmAtracciones();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOperarios frm = new frmOperarios();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "PARQUE DE ATRACCIONES - DIVERTIMENTO S.A.";
        }
    }
}
