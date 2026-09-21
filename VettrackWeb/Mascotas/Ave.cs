using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Interfaces;
using VettrackWeb.Mascotas;

namespace Vettrack.Mascotas
{
    public class Ave : Mascota, IVacunable, IRequiereManejoEspecial
    {
        public string Especie { get; set; }
        public List<Vacuna> HistorialVacunas { get; private set; } = new();

        public Ave(string nombre, DateTime fechaNacimiento, decimal pesoKg, string especie)
            : base(nombre, fechaNacimiento, pesoKg)
        {
            Especie = especie;
        }

        public override string TipoMascota => "Ave";

        public override decimal CalcularCostoConsultaBase() => 700m + RecargoManejo();

        public override string ObtenerRecomendacionesCuidado() =>
            $"Dieta balanceada según la especie {Especie} y revisión de plumaje mensual.";

        public void AgregarVacuna(Vacuna vacuna) => HistorialVacunas.Add(vacuna);

        public bool EstaVacunacionAlDia() =>
            HistorialVacunas.Any() &&
            HistorialVacunas.Max(v => v.FechaAplicacion) > DateTime.Today.AddMonths(-6);

        public string ProtocoloManejo() => "Sujeción suave y evitar ruidos fuertes.";

        public decimal RecargoManejo() => 150m;
    }
}
