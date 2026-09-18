using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Duenos;

namespace Vettrack.Repositorios
{
    public class RepositorioDueno: IRepositorio <Dueno>
    {
        private List <Dueno> dueno = new();
        private int siguienteId = 1;
        public void Agregar(Dueno entidad) { entidad.Id = siguienteId++; dueno.Add(entidad); }
        public List<Dueno> ObtenerTodos() => dueno;
        public Dueno? ObtenerPorId(int id) => dueno.FirstOrDefault (d => d.Id == id);
        public void Actualizar(Dueno entidad) { var index = dueno.FindIndex (d => d.Id == entidad.Id);
            if (index >= 0) dueno[index] = entidad;
        }
        public void Eliminar(int id) { var _dueno = ObtenerPorId(id); 
            if (_dueno != null) dueno.Remove(_dueno); }
    }
}
