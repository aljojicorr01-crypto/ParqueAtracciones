using ParqueAtracciones.Controlador;
using ParqueAtracciones.Entidades;

namespace ParqueAtracciones.Formulario
{
    public partial class frmAtracciones : Form
    {
        public frmAtracciones()
        {
            InitializeComponent();

            this.Load += frmAtracciones_Load;
        }

        private void frmAtracciones_Load(object sender, EventArgs e)
        {
            this.Text = "CONTROL DE ATRACCIONES";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Noria");
            comboBox1.Items.Add("Montaña Rusa");
            comboBox1.Items.Add("Todo");
            comboBox1.Text = "Todo";
            dataGridView1.AutoGenerateColumns = true;

            InicializarAtracciones();
            InicializarVehiculos();
            InicializarVagones();

            Listar();
        }

        public void InicializarAtracciones()
        {
            TLista.ListaAtracciones.Clear();
            Noria n1 = new Noria("NR01", "Noria Gigante", "Zona Norte", 20);
            n1.PersonasDentro = 10;

            Noria n2 = new Noria("NR02", "Rueda Infantil", "Zona Familiar", 10);
            n2.PersonasDentro = 5;

            MontañaRusa m1 = new MontañaRusa("MR01", "Dragon Rojo", "Zona Extrema", 30);
            m1.PersonasDentro = 15;

            MontañaRusa m2 = new MontañaRusa("MR02", "Tormenta Azul", "Zona Oeste", 25);
            m2.PersonasDentro = 7;

            TLista.ListaAtracciones.Add(n1);
            TLista.ListaAtracciones.Add(n2);
            TLista.ListaAtracciones.Add(m1);
            TLista.ListaAtracciones.Add(m2);
        }

        public void InicializarVehiculos()
        {
            TLista.ListaVehiculos.Clear();
            Noria n1 = (Noria)TLista.ListaAtracciones[0];
            TLista.ListaVehiculos.Add( new Vehiculo("VH01", 1, true, n1));
            TLista.ListaVehiculos.Add( new Vehiculo("VH02", 2, true, n1));
            TLista.ListaVehiculos.Add( new Vehiculo("VH03", 3, false, n1));
        }

        public void InicializarVagones()
        {
            TLista.ListaVagones.Clear();
            MontañaRusa m1 = (MontañaRusa)TLista.ListaAtracciones[2];
            TLista.ListaVagones.Add( new Vagon("VG01", 1, true, m1));
            TLista.ListaVagones.Add( new Vagon("VG02", 2, true, m1));
            TLista.ListaVagones.Add( new Vagon("VG03", 3, false, m1));
        }

        public void Listar()
        {
            dataGridView1.DataSource = null;
            if (comboBox1.Text == "Noria")
            {
                dataGridView1.DataSource = TLista.ListaAtracciones.Where(x => x is Noria).ToList();
            }else if (comboBox1.Text == "Montaña Rusa"){
                dataGridView1.DataSource = TLista.ListaAtracciones.Where(x => x is MontañaRusa).ToList();
            }else{
                dataGridView1.DataSource = TLista.ListaAtracciones.ToList();
            }
            dataGridView1.Refresh();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmEditor frm = new frmEditor("Noria");
            frm.a = null;
            frm.ShowDialog();
            Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una atraccion");
                return;
            }
            Atraccion a =(Atraccion)dataGridView1.CurrentRow.DataBoundItem;
            frmEditor frm = new frmEditor("");
            frm.a = a;
            frm.ShowDialog();
            Listar();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una atraccion");
                return;
            }
            Atraccion a = (Atraccion)dataGridView1.CurrentRow.DataBoundItem;
            TLista.ListaAtracciones.Remove(a);
            Listar();
            MessageBox.Show("Atraccion eliminada");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una atraccion");
                return;
            }
            Atraccion a = (Atraccion)dataGridView1.CurrentRow.DataBoundItem;
            CRA cra = new CRA();
            if (a is Noria)
            {
                Vehiculo v = TLista.ListaVehiculos[2];
                v.DetectarFallo(cra);
            }
            else if (a is MontañaRusa)
            {
                Vagon v = TLista.ListaVagones[2];
                v.DetectarFallo(cra);
            }
            textBox3.Text = a.AveriasPendientes.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una atraccion");
                return;
            }
            Atraccion a = (Atraccion)dataGridView1.CurrentRow.DataBoundItem;

            if (a.AveriasPendientes > 0)
            {
                textBox4.Text = "AMARILLO";
                MessageBox.Show("La atraccion tiene averias");
                return;
            }
            if (a.PersonasDentro <= 0)
            {
                MessageBox.Show("No hay personas");
                return;
            }
            textBox4.Text = "VERDE";
            MessageBox.Show(a.Iniciar());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una atraccion");
                return;
            }
            Atraccion a = (Atraccion)dataGridView1.CurrentRow.DataBoundItem;
            textBox1.Text = a.PersonasDentro.ToString();
            textBox2.Text = a.Capacidad.ToString();
            textBox3.Text = a.AveriasPendientes.ToString();
            if (a.AveriasPendientes > 0)
            {
                textBox4.Text = "AMARILLO";
            }else{
                textBox4.Text = "VERDE";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
