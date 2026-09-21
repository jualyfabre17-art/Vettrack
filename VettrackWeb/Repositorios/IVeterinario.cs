using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Veterinarios;

namespace Vettrack.Repositorios
{
    public class VeterinarioRepository: IRepositorio<Veterinario>
    {
        private List<Veterinario> veterinario = new();
        private int siguienteId = 1;

        public void Agregar(Veterinario entidad) { entidad.Id = siguienteId++; veterinario.Add(entidad); }
        public Veterinario? ObtenerPorId(int id) => veterinario.FirstOrDefault (v => v.Id == id);
        public List<Veterinario> ObtenerTodos() => veterinario; 
        public void Actualizar(Veterinario entidad) { var index = veterinario.FindIndex(v => v.Id == entidad.Id);
        if (index >=0) veterinario[index] = entidad;}
        public void Eliminar(int id) { var _veterinario = ObtenerPorId(id);
            if (_veterinario != null) veterinario.Remove(_veterinario); }
    }
}
