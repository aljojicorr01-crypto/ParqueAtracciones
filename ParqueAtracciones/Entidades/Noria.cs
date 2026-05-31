using System.Collections.Generic;

namespace ParqueAtracciones.Entidades
{
    public class Noria : Atraccion
    {
        public List<Vehiculo> ListaVehiculos { get; set; }

        public Noria()
        {
            ListaVehiculos = new List<Vehiculo>();
        }

        public Noria(string codigo, string nombre, string calle, int capacidad)
            : base(codigo, nombre, calle, capacidad)
        {
            ListaVehiculos = new List<Vehiculo>();
        }

        public override string Iniciar()
        {
            return "Noria en funcionamiento";
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}