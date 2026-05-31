using System.Collections.Generic;

namespace ParqueAtracciones.Entidades
{
    public class MontañaRusa : Atraccion
    {
        public List<Vagon> ListaVagones { get; set; }

        public MontañaRusa()
        {
            ListaVagones = new List<Vagon>();
        }

        public MontañaRusa(string codigo, string nombre, string calle, int capacidad)
            : base(codigo, nombre, calle, capacidad)
        {
            ListaVagones = new List<Vagon>();
        }

        public override string Iniciar()
        {
            return "Montaña rusa iniciada";
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}