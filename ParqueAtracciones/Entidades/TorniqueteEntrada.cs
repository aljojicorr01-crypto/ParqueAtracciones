using System.Windows.Forms;

namespace ParqueAtracciones.Entidades
{
    public class TorniqueteEntrada
    {
        public Atraccion Atraccion { get; set; }

        public TorniqueteEntrada(Atraccion atraccion)
        {
            Atraccion = atraccion;
        }

        public void EntrarPersona()
        {
            if (Atraccion.PersonasDentro < Atraccion.Capacidad)
            {
                Atraccion.PersonasDentro++;
                MessageBox.Show( "Persona ingresó");
            }

            else
            {
                MessageBox.Show( "Atracción llena");
            }
        }
    }
}