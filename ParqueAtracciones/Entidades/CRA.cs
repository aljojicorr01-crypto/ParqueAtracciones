using ParqueAtracciones.Controlador;
using ParqueAtracciones.Entidades;

namespace ParqueAtracciones.Entidades
{
    public class CRA
    {
    public Operario OperarioActual { get; set; }

        public void ReportarAveria(string atraccion,int numero)
    {
        OperarioActual = TLista.BuscarOperarioLibre();

        if (OperarioActual != null)
        {
            OperarioActual.Dispositivo.RecibirMensaje("Avería en " +atraccion +" componente #" + numero);
            OperarioActual.Disponible = false;
        }
      }
    }
}