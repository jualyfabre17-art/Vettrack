using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Interfaces;
using VettrackWeb.Mascotas;

namespace Vettrack.Mascotas
{
    public class Gato : Mascota, IVacunable
    {
        public bool EsInterior { get; set; }
        public List<Vacuna> HistorialVacunas { get; private set; } = new();

        public Gato(string nombre, DateTime fechaNacimiento, decimal pesoKg, bool esInterior)
            : base(nombre, fechaNacimiento, pesoKg)
        {
            EsInterior = esInterior;
        }

        public override string TipoMascota => "Gato";

        public override decimal CalcularCostoConsultaBase() => 450m;

        public override string ObtenerRecomendacionesCuidado() =>
            EsInterior
                ? "Enriquecimiento ambiental y control de peso."
                : "Vacuna contra leucemia felina recomendada.";

        public void AgregarVacuna(Vacuna vacuna) => HistorialVacunas.Add(vacuna);

        public bool EstaVacunacionAlDia() =>
            HistorialVacunas.Any() &&
            HistorialVacunas.Max(v => v.FechaAplicacion) > DateTime.Today.AddYears(-1);
    }
}
