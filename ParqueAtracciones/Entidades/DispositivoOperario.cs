using System.Windows.Forms;

namespace ParqueAtracciones.Entidades
{
    public class DispositivoOperario
    {
        public bool Ocupado { get; set; }

        public bool Disponible { get; internal set; }

        public DispositivoOperario()
        {
            Ocupado = false;
            Disponible = true;
        }

        public void RecibirMensaje(string mensaje)
        {
            Ocupado = true;
            Disponible = false;

            MessageBox.Show(mensaje);
        }

        public void Liberar()
        {
            Ocupado = false;
            Disponible = true;
        }
    }
}