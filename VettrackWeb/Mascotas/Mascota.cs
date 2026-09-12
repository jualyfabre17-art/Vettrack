using System;
using System.Collections.Generic;
using System.Text;

namespace Vettrack.Mascotas
{
    public abstract class Mascota
    {
        public string Nombre { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Dueno { get; set; }
        public string Especie { get; }

        public Mascota(string Nombre, DateOnly FechaNacimiento, string Dueno, string Especie)
        {
            this.Nombre = Nombre;
            this.FechaNacimiento = FechaNacimiento;
            this.Dueno = Dueno;
            this.Especie = Especie;
        }

        public abstract double CalcularCosto();
        public abstract void Recomendaciones(string recomendacion);
    }
}
