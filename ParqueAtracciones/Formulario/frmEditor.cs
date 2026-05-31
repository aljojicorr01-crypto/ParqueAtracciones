using ParqueAtracciones.Controlador;
using ParqueAtracciones.Entidades;

namespace ParqueAtracciones.Formulario
{
    public partial class frmEditor : Form
    {
        string tipo = "";

        public Atraccion a = null;
        public frmEditor(string t)
        {

            InitializeComponent();
            tipo = t;
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            this.Text = "EDITOR";

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Noria");
            comboBox1.Items.Add("Montaña Rusa");

            comboBox1.Text = tipo;

            if (a != null)
            {
                textBox1.Text = a.Codigo;
                textBox2.Text = a.Nombre;
                textBox3.Text = a.Calle;
                textBox4.Text = a.Capacidad.ToString();
                textBox5.Text = a.PersonasDentro.ToString();

                if (a is Noria)
                {
                    comboBox1.Text = "Noria";
                }
                else
                {
                    comboBox1.Text = "Montaña Rusa";
                }
            }
        }

        public void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (a != null)
                {
                    a.Codigo = textBox1.Text;
                    a.Nombre = textBox2.Text;
                    a.Calle = textBox3.Text;
                    a.Capacidad = int.Parse(textBox4.Text);
                    a.PersonasDentro = int.Parse(textBox5.Text);

                    MessageBox.Show("Datos editados");

                    Close();
                    return;
                }
                if (comboBox1.Text == "Noria")
                {
                    Noria n = new Noria();
                    n.Codigo = textBox1.Text;
                    n.Nombre = textBox2.Text;
                    n.Calle = textBox3.Text;
                    n.Capacidad = int.Parse(textBox4.Text);
                    n.PersonasDentro = int.Parse(textBox5.Text);
                    TLista.ListaAtracciones.Add(n);

                    MessageBox.Show("Noria agregada");
                }
                else if (comboBox1.Text == "Montaña Rusa")
                {
                    MontañaRusa m = new MontañaRusa();
                    m.Codigo = textBox1.Text;
                    m.Nombre = textBox2.Text;
                    m.Calle = textBox3.Text;
                    m.Capacidad = int.Parse(textBox4.Text);
                    m.PersonasDentro = int.Parse(textBox5.Text);
                    TLista.ListaAtracciones.Add(m);

                    MessageBox.Show("Montaña rusa agregada");
                }

                Limpiar();
                Close();
            }
            catch
            {
                MessageBox.Show("Error en datos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
