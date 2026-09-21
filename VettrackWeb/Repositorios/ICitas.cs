using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Citas;

namespace Vettrack.Repositorios
{
    public class RepositorioCitas : IRepositorio<Cita>
    {
        private List <Cita> cita = new();
        private int siguienteId = 1;
        public void Agregar(Cita entidad) { entidad.Id = siguienteId++; cita.Add(entidad); }
        public Cita? ObtenerPorId(int id) => cita.FirstOrDefault(c => c.Id == id);
        public List<Cita> ObtenerTodos() => cita;
        public void Actualizar(Cita entidad) { var index = cita.FindIndex(c => c.Id == entidad.Id);
            if (index >= 0) cita[index] = entidad; }
        public void Eliminar(int id) { var citas = ObtenerPorId(id);
            if (cita != null) cita.Remove(citas);
        }
    }
}
