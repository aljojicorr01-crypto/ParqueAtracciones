using System.Windows.Forms;

namespace ParqueAtracciones.Entidades
{
    public class Vagon
    {
        public string Codigo { get; set; }
        public bool Acoplado { get; set; }
        public MontañaRusa Atraccion { get; set; }
        public int Numero { get; set; }


        public Vagon()
        {
        }

        public Vagon(string codigo,int numero, bool acoplado,MontañaRusa atraccion)
        {
            Codigo = codigo;
            Numero = numero;
            Acoplado = acoplado;
            Atraccion = atraccion;
        }

        public void DetectarFallo(
            CRA cra)
        {
            if (!Acoplado)
            {
                MessageBox.Show("Fallo en vagón");
                cra.ReportarAveria(Atraccion.Nombre,Numero);
                Atraccion.AveriasPendientes++;
            }
        }


    }
}