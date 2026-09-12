using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Duenos;

namespace Vettrack.Repositorios
{
    public class IDueno: IRepositorio <Dueno>
    {
        private List <Dueno> dueno = new List<Dueno> ();
        public void Agregar(Dueno entidad) { }
        public List<Dueno> ObtenerTodos() { return dueno; }
        public Dueno ObtenerPorId(int id) { return null; }
        public void Actualizar(Dueno entidad) { }
        public void Eliminar(int id) { }
    }
}
