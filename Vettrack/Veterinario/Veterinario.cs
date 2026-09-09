using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Vettrack.Veterinarios
{
    public class Veterinario
    {
        public int IdVeterinario { get; set; }
        public string NombreCompleto { get; set; }
        public string Especialidad {  get; set; }
        public string Telefono { get; set; }

        public Veterinario( int IdVeterinario, string NombreCompleto, string Especialidad, string Telefono)
        {
            this.IdVeterinario = IdVeterinario;
            this.NombreCompleto = NombreCompleto;
            this.Especialidad = Especialidad;
            this.Telefono = Telefono;
        }
    }
}
