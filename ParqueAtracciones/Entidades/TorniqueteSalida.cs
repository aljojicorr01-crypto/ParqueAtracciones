using System.Windows.Forms;

namespace ParqueAtracciones.Entidades
{
    public class TorniqueteSalida
    {
        public Atraccion Atraccion { get; set; }
        public TorniqueteSalida( Atraccion atraccion)
        {
            Atraccion = atraccion;
        }

        public void SalirPersona()
        {
            if ( Atraccion.PersonasDentro > 0)
            {
                Atraccion.PersonasDentro--;

                MessageBox.Show("Persona salió");
            }
        }
    }
}