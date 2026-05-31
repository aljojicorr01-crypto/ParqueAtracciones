using System.Windows.Forms;

namespace ParqueAtracciones.Entidades
{
    public class Vehiculo
    {
        public string Codigo { get; set; }
        public int Numero { get; set; }
        public bool Anclado { get; set; }
        public Noria Atraccion { get; set; }

        public Vehiculo()
        {
        }

        public Vehiculo(string codigo, int numero, bool anclado, Noria atraccion)
        {
            Codigo = codigo;
            Numero = numero;
            Anclado = anclado;
            Atraccion = atraccion;
        }

        public void DetectarFallo(CRA cra)
        {
            if (!Anclado)
            {
                MessageBox.Show("Fallo detectado");

                cra.ReportarAveria(Atraccion.Nombre, Numero);

                Atraccion.AveriasPendientes++;
            }
        }
    }
}