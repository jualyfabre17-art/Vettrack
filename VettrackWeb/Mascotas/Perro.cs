using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Interfaces;
using VettrackWeb.Mascotas;

namespace Vettrack.Mascotas
{
    public class Perro : Mascota, IVacunable
    {
        public string Raza { get; set; }
        public List<Vacuna> HistorialVacunas { get; private set; } = new();

        public Perro(string nombre, DateTime fechaNacimiento, decimal pesoKg, string raza)
            : base(nombre, fechaNacimiento, pesoKg)
        {
            Raza = raza;
        }

        public override string TipoMascota => "Perro";

        public override decimal CalcularCostoConsultaBase()
        {
            decimal costo = 500m;
            if (PesoKg > 25) costo += 150m;
            return costo;
        }

        public override string ObtenerRecomendacionesCuidado() =>
            $"Paseos diarios de al menos 30 minutos y control antiparasitario cada 3 meses. Raza: {Raza}.";

        public void AgregarVacuna(Vacuna vacuna) => HistorialVacunas.Add(vacuna);

        public bool EstaVacunacionAlDia() =>
            HistorialVacunas.Any() &&
            HistorialVacunas.Max(v => v.FechaAplicacion) > DateTime.Today.AddYears(-1);
    }
}

