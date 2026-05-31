using System.Collections.Generic;

namespace ParqueAtracciones.Entidades
{
    public abstract class Atraccion
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int Capacidad { get; set; }
        public int PersonasDentro { get; set; }
        public int AveriasPendientes { get; set; }

        public Atraccion()
        {
            Codigo = "";
            Nombre = "";
            Calle = "";
            Capacidad = 0;

            PersonasDentro = 0;
            AveriasPendientes = 0;
        }
        public Atraccion(string codigo, string nombre, string calle, int capacidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Calle = calle;
            Capacidad = capacidad;

            PersonasDentro = 0;
            AveriasPendientes = 0;
        }

        public virtual string Iniciar()
        {
            return "Atracción iniciada";
        }
    }
}