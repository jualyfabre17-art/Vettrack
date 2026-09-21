using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Duenos;

namespace Vettrack.Mascotas
{
    public abstract class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        protected decimal PesoKg { get; set; }

        public int DuenoId { get; set; }
        public Dueno? Dueno { get; set; }

        protected Mascota(string nombre, DateTime fechaNacimiento, decimal pesoKg)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            PesoKg = pesoKg;
        }

        public int EdadEnAnios =>
            DateTime.Today.Year - FechaNacimiento.Year -
            (DateTime.Today.DayOfYear < FechaNacimiento.DayOfYear ? 1 : 0);

        public abstract string TipoMascota { get; }
        public abstract decimal CalcularCostoConsultaBase();
        public abstract string ObtenerRecomendacionesCuidado();
    }
}
