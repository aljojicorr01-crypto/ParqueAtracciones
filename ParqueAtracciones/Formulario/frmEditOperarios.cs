using ParqueAtracciones.Controlador;
using ParqueAtracciones.Entidades;

namespace ParqueAtracciones.Formulario
{
    public partial class frmEditOperarios : Form
    {
        public Operario op = null;

        public frmEditOperarios()
        {
            InitializeComponent();
        }

        private void frmEditOperarios_Load(object sender, EventArgs e)
        {
            this.Text = "EDITOR";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Operario");
            comboBox1.Items.Add("Vehiculo");
            comboBox1.Items.Add("Vagon");
            comboBox1.Text = "Operario";

            if (op != null)
            {
                comboBox1.Text = "Operario";
                textBox1.Text = op.Codigo;
                textBox2.Text = op.Nombre;
                textBox3.Text = op.AveriasAtendidas.ToString();
                checkBox1.Checked = op.Disponible;
            }
        }

        public void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            checkBox1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (op != null)
                {
                    op.Codigo = textBox1.Text;
                    op.Nombre = textBox2.Text;
                    op.AveriasAtendidas = int.Parse(textBox3.Text);
                    op.Disponible = checkBox1.Checked;
                    MessageBox.Show("Operario editado");

                    Close();
                    return;
                }
                if (comboBox1.Text == "Operario")
                {
                    Operario o = new Operario();
                    o.Codigo = textBox1.Text;
                    o.Nombre = textBox2.Text;
                    o.AveriasAtendidas = int.Parse(textBox3.Text);
                    o.Disponible = checkBox1.Checked;
                    o.Dispositivo = new DispositivoOperario();
                    TLista.ListaOperarios.Add(o);
                    MessageBox.Show("Operario agregado");
                }
                else if (comboBox1.Text == "Vehiculo")
                {
                    Vehiculo v = new Vehiculo();
                    v.Codigo = textBox1.Text;
                    v.Numero = int.Parse(textBox2.Text);
                    v.Anclado = checkBox1.Checked;
                    TLista.ListaVehiculos.Add(v);
                    MessageBox.Show("Vehiculo agregado");
                }
                else if (comboBox1.Text == "Vagon")
                {
                    Vagon vg = new Vagon();
                    vg.Codigo = textBox1.Text;
                    vg.Numero = int.Parse(textBox2.Text);
                    vg.Acoplado = checkBox1.Checked;
                    TLista.ListaVagones.Add(vg);
                    MessageBox.Show("Vagon agregado");
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
            if (comboBox1.Text == "Operario")
            {
                label1.Text = "Codigo";
                label2.Text = "Nombre";
                label3.Text = "Averias";
                checkBox1.Text = "Disponible";
            }
            else if (comboBox1.Text == "Vehiculo")
            {
                label1.Text = "Codigo";
                label2.Text = "Numero";
                label3.Text = "No usar";
                checkBox1.Text = "Anclado";
            }
            else if (comboBox1.Text == "Vagon")
            {
                label1.Text = "Codigo";
                label2.Text = "Numero";
                label3.Text = "No usar";
                checkBox1.Text = "Acoplado";
            }
        }
    }
}
