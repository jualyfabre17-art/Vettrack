using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using Vettrack.Duenos;
using Vettrack.Mascotas;

namespace Vettrack.Veterinarios
{
    public enum Especialidad { General, Cirugia, Exoticos, Dermatologia }
    public class Veterinario
    {
        
        public int Id { get; set; }
            public string Nombre { get; set; } = string.Empty;
            public Especialidad Especialidad { get; set; }
    }
}
