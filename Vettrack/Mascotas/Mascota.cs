using System;
using System.Collections.Generic;
using System.Text;

namespace Vettrack.Mascotas
{
    public abstract class Mascota
    {
        string nombre { get; set; }
        DateOnly fechaNacimiento { get; set; }
        string dueno { get; set; }
        string especie { get; set; }

        public Mascota(string nombre, DateOnly fechaNacimiento, string dueno, string especie)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dueno = dueno;
            this.especie = especie;
        }

        public abstract double CalcularCosto();
        public abstract void Recomendaciones(string recomendacion);
    }
}
