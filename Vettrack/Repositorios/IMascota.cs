using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Mascotas;
using Vettrack.Repositorios;

namespace Vettrack.Repositorios
{
    public class RepositorioMascota: IRepositorio<Mascota>
    {
        private List <Mascota> mascota = new List<Mascota>();
        public void Agregar(Mascota entidad) { }
        public Mascota ObtenerPorId(int id) { return null; }
        public List<Mascota> ObtenerTodos() { return mascota; }
        public void Actualizar(Mascota entidad) { }
        public void Eliminar(int id) { }
    }
}
