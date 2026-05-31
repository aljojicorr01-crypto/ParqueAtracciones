using System.Windows.Forms;

namespace ParqueAtracciones.Entidades
{
    public class ControladorArranque
    {
        public Atraccion Atraccion { get; set; }

        public ControladorArranque(Atraccion atraccion)
        {
            Atraccion = atraccion;
        }

        public void Iniciar()
        {
            if (Atraccion.AveriasPendientes == 0)
            {
                MessageBox.Show(Atraccion.Iniciar() );
            }

            else
            {
                MessageBox.Show("Hay averías pendientes");
            }
        }
    }
}