using System;
using System.Collections.Generic;
using System.Text;

namespace Vettrack.Mascotas
{
    public abstract class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Dueno { get; set; }
        public string Especie { get; }

        public Mascota(int Id, string Nombre, DateOnly FechaNacimiento, string Dueno, string Especie)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.FechaNacimiento = FechaNacimiento;
            this.Dueno = Dueno;
            this.Especie = Especie;
        }

        public abstract decimal CalcularCosto();
        public abstract void Recomendaciones(string recomendacion);
    }
}
