using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Citas;

namespace Vettrack.Repositorios
{
    public class ICitas : IRepositorio<Cita>
    {
        private List <Cita> cita = new List<Cita> ();

        public void Agregar(Cita entidad) { }
        public Cita ObtenerPorId(int id) { return null; }
        public List<Cita> ObtenerTodos() { return cita; }
        public void Actualizar(Cita entidad) { }
        public void Eliminar(int id) { }
    }
}
