using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Interfaces;

namespace Vettrack.Mascotas
{
    public class Exotico : Mascota, IRequiereManejoEspecial
    {
        public string Especie { get; set; }

        public Exotico(string nombre, DateTime fechaNacimiento, decimal pesoKg, string especie)
            : base(nombre, fechaNacimiento, pesoKg)
        {
            Especie = especie;
        }

        public override string TipoMascota => "Exótico";

        public override decimal CalcularCostoConsultaBase() => 900m + RecargoManejo();

        public override string ObtenerRecomendacionesCuidado() =>
            $"Requiere temperatura y humedad controladas según la especie ({Especie}).";

        public string ProtocoloManejo() => "Manipular con guantes y minimizar el estrés del animal.";

        public decimal RecargoManejo() => 300m;
    }
}

