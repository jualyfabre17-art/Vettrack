using System;
using System.Collections.Generic;
using System.Text;

namespace Vettrack.Duenos
{
    public class Dueno
    {
        public int Id {  get; set; }
        public string NombreCompleto {  get; set; }
        public string Telefono { get; set; }
        public string Direccion {  get; set; }

        public Dueno(int Id,string NombreCompleto,string Telefono,string Direccion) 
        {
            this.Id = Id;
            this.NombreCompleto = NombreCompleto;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }
    }
}
