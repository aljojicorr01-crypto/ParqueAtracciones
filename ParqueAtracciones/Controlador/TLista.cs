using ParqueAtracciones.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace ParqueAtracciones.Controlador
{
    public class TLista
    {
        public static List<Atraccion> ListaAtracciones = new List<Atraccion>();

        public static List<Operario> ListaOperarios = new List<Operario>();

        public static List<Vehiculo> ListaVehiculos = new List<Vehiculo>();

        public static List<Vagon> ListaVagones = new List<Vagon>();

        public static void AgregarAtraccion(Atraccion a)
        {
            ListaAtracciones.Add(a);
        }

        public static void AgregarOperario(Operario o)
        {
            ListaOperarios.Add(o);
        }

        public static void AgregarVehiculo(Vehiculo v)
        {
            ListaVehiculos.Add(v);
        }

        public static void AgregarVagon(Vagon v)
        {
            ListaVagones.Add(v);
        }

        public static Atraccion BuscarAtraccion(string codigo)
        {
            return ListaAtracciones.FirstOrDefault(x => x.Codigo == codigo);
        }

        public static Operario BuscarOperarioLibre()
        {
            return ListaOperarios.FirstOrDefault(x => x.Disponible == true);
        }

        public static void EliminarAtraccion(int pos)
        {
            ListaAtracciones.RemoveAt(pos);
        }

        public static void EliminarOperario(int pos)
        {
            ListaOperarios.RemoveAt(pos);
        }

        public static List<Atraccion> ListarAtracciones()
        {
            return ListaAtracciones;
        }

        public static List<Operario> ListarOperarios()
        {
            return ListaOperarios;
        }
    }
}