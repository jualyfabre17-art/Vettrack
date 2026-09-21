using System;
using System.Collections.Generic;
using System.Text;


namespace Vettrack.Citas
{
    public enum EstadoCita { Pendiente, Confirmada, Completada, Cancelada }

    public class Cita
    {
        public int Id { get; set; }
        public int MascotaId { get; set; }
        public int VeterinarioId { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public EstadoCita Estado { get; set; } = EstadoCita.Pendiente;
    }
}
