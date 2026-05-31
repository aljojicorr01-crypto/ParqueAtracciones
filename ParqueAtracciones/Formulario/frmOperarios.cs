using ParqueAtracciones.Controlador;
using ParqueAtracciones.Entidades;

namespace ParqueAtracciones.Formulario
{
    public partial class frmOperarios : Form
    {
        public frmOperarios()
        {
            InitializeComponent();
            this.Load += frmOperarios_Load;
        }

        private void frmOperarios_Load(object sender, EventArgs e)
        {
            this.Text = "CENTRAL DE MANTENIMIENTO";

            comboBox1.Items.Clear();

            comboBox1.Items.Add("Operarios");
            comboBox1.Items.Add("Vehiculos");
            comboBox1.Items.Add("Vagones");

            comboBox1.Text = "Operarios";

            dataGridView1.AutoGenerateColumns = true;

            InicializarOperarios();
            InicializarVehiculos();
            InicializarVagones();

            ListarOperarios();
        }
        public void InicializarOperarios()
        {
            TLista.ListaOperarios.Clear();
            Operario op1 = new Operario("OP01", "Carlos Mendoza");
            op1.AveriasAtendidas = 5;

            TLista.ListaOperarios.Add(op1);

            Operario op2 = new Operario("OP02", "Jorge Castillo");
            op2.AveriasAtendidas = 2;

            TLista.ListaOperarios.Add(op2);

            Operario op3 = new Operario("OP03", "Daniel Romero");
            op3.AveriasAtendidas = 7;

            TLista.ListaOperarios.Add(op3);

            Operario op4 = new Operario("OP04", "Mateo Torres");
            op4.AveriasAtendidas = 1;

            TLista.ListaOperarios.Add(op4);

            Operario op5 = new Operario("OP05", "Luis Herrera");
            op5.AveriasAtendidas = 3;

            TLista.ListaOperarios.Add(op5);
        }

        public void InicializarVehiculos()
        {
            TLista.ListaVehiculos.Clear();
            Noria n1 = new Noria("NR01","Noria Gigante","Zona Norte",20);
            Vehiculo v1 = new Vehiculo("VH01", 1, true, n1);
            Vehiculo v2 = new Vehiculo("VH02", 2, true, n1);
            Vehiculo v3 = new Vehiculo("VH03", 3, false, n1);
            TLista.ListaVehiculos.Add(v1);
            TLista.ListaVehiculos.Add(v2);
            TLista.ListaVehiculos.Add(v3);
        }

        public void InicializarVagones()
        {
            TLista.ListaVagones.Clear();
            MontañaRusa m1 = new MontañaRusa("MR01", "Dragon Rojo", "Zona Extrema",30);
            Vagon vg1 = new Vagon("VG01", 1, true, m1);
            Vagon vg2 = new Vagon("VG02", 2, true, m1);
            Vagon vg3 = new Vagon("VG03", 3, false, m1);
            TLista.ListaVagones.Add(vg1);
            TLista.ListaVagones.Add(vg2);
            TLista.ListaVagones.Add(vg3);
        }

        public void ListarOperarios()
        {
            dataGridView1.DataSource = null;
            if (comboBox1.Text == "Operarios")
            {
                dataGridView1.DataSource = TLista.ListaOperarios.ToList();
            }
            else if (comboBox1.Text == "Vehiculos")
            {
                dataGridView1.DataSource = TLista.ListaVehiculos.ToList();
            }
            else if (comboBox1.Text == "Vagones")
            {
                dataGridView1.DataSource = TLista.ListaVagones.ToList();
            }
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditOperarios frm = new frmEditOperarios();
            frm.ShowDialog();
            ListarOperarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Operarios")
            {
                MessageBox.Show("Solo funciona con operarios");
                return;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un operario");
                return;
            }

            Operario op = (Operario)dataGridView1.CurrentRow.DataBoundItem;
            op.Disponible = true;
            if (op.Dispositivo != null)
            {
                op.Dispositivo.Liberar();
            }
            ListarOperarios();
            MessageBox.Show("Operario liberado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un dato");
                return;
            }
            if (comboBox1.Text == "Operarios")
            {
                Operario op = (Operario)dataGridView1.CurrentRow.DataBoundItem;
                TLista.ListaOperarios.Remove(op);
                MessageBox.Show("Operario eliminado");
            }
            else if (comboBox1.Text == "Vehiculos")
            {
                Vehiculo v = (Vehiculo)dataGridView1.CurrentRow.DataBoundItem;
                TLista.ListaVehiculos.Remove(v);
                MessageBox.Show("Vehiculo eliminado");
            }
            else if (comboBox1.Text == "Vagones")
            {
                Vagon vg = (Vagon)dataGridView1.CurrentRow.DataBoundItem;
                TLista.ListaVagones.Remove(vg);
                MessageBox.Show("Vagon eliminado");
            }
            ListarOperarios();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un dato");
                return;
            }
            if (comboBox1.Text == "Operarios")
            {
                Operario op = (Operario)dataGridView1.CurrentRow.DataBoundItem;
                string estado = "";
                if (op.Disponible)
                {
                    estado = "DISPONIBLE";
                }else{
                    estado = "OCUPADO";
                }
                MessageBox.Show( "OPERARIO: " + op.Nombre + "\n\nCODIGO: " + op.Codigo + "\n\nAVERIAS: " + op.AveriasAtendidas + "\n\nESTADO: " + estado);
            }
            else if (comboBox1.Text == "Vehiculos")
            {
                Vehiculo v = (Vehiculo)dataGridView1.CurrentRow.DataBoundItem;
                string estado = "";
                if (v.Anclado)
                {
                    estado = "ANCLADO";
                }else{
                    estado = "SUELTO";
                }
                MessageBox.Show("VEHICULO: " + v.Codigo + "\n\nNUMERO: " + v.Numero + "\n\nESTADO: " + estado);
            }
            else if (comboBox1.Text == "Vagones")
            {
                Vagon vg = (Vagon)dataGridView1.CurrentRow.DataBoundItem;
                string estado = "";

                if (vg.Acoplado)
                {
                    estado = "ACOPLADO";
                }else{
                    estado = "DESACOPLADO";
                }
                MessageBox.Show("VAGON: " + vg.Codigo + "\n\nNUMERO: " + vg.Numero + "\n\nESTADO: " + estado);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Operarios")
            {
                MessageBox.Show("Solo se editan operarios");
                return;
            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un operario");
                return;
            }
            Operario op =(Operario)dataGridView1.CurrentRow.DataBoundItem;
            frmEditOperarios frm =new frmEditOperarios();
            frm.op = op;

            frm.ShowDialog();
            ListarOperarios();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarOperarios();
        }
    }
}
