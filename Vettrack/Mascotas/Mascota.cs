using System;
using System.Collections.Generic;
using System.Text;

namespace Vettrack.Mascotas
{
    public abstract class Mascota
    {
        string Nombre { get; set; }
        DateOnly FechaNacimiento { get; set; }
        string Dueno { get; set; }
        string Especie { get; set; }

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
