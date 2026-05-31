using ParqueAtracciones.Entidades;

namespace ParqueAtracciones.Entidades
{
    public class Operario
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Disponible { get; set; }
        public int AveriasAtendidas { get; set; }
        public DispositivoOperario Dispositivo { get; set; }

        public Operario( string codigo,string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;

            Disponible = true;
            AveriasAtendidas = 0;
            Dispositivo = new DispositivoOperario();
        }

        public Operario()
        {
        }

        public void Ocupar()
        {
            Disponible = false;
        }

        public void Liberar()
        {
            Disponible = true;
        }
    }
}