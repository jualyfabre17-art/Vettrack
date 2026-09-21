using System;
using System.Collections.Generic;
using System.Text;


namespace Vettrack.Citas
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string MotivoConsulta { get; set; }
        public string MascotaAsociada { get; set; }

        public Cita(int Id, DateTime FechaHora, string MotivoConsulta, string MascotaAsociada) 
        {
            this.Id = Id;
            this.FechaHora = FechaHora;
            this.MotivoConsulta = MotivoConsulta;
            this.MascotaAsociada = MascotaAsociada;
        }
        
    }
}
