using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using Vettrack.Mascotas;

namespace Vettrack.Veterinarios
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Especialidad {  get; set; }
        public string Telefono { get; set; }
        public Mascota Mascota { get; private set; }
        public Veterinario Veterinarioo { get; private set; }

        public Veterinario( int Id, string NombreCompleto, string Especialidad, string Telefono)
        {
            this.Id = Id;
            this.NombreCompleto = NombreCompleto;
            this.Especialidad = Especialidad;
            this.Telefono = Telefono;
        }
    }
}
