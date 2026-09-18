using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Mascotas;
using Vettrack.Repositorios;

namespace Vettrack.Repositorios
{
    public class RepositorioMascota: IRepositorio<Mascota>
    {
        private List <Mascota> mascota = new();
        private int siguienteId = 1;
        public void Agregar(Mascota entidad) { entidad.Id = siguienteId++; mascota.Add(entidad); }
        public Mascota? ObtenerPorId(int id) => mascota.FirstOrDefault(m => m.Id == id);
        public List<Mascota> ObtenerTodos() { return mascota; }
        public void Actualizar(Mascota entidad) { var index = mascota.FindIndex(m => m.Id == entidad.Id);
            if (index > 0) mascota[index] = entidad;}
        public void Eliminar(int id) { var _mascota = ObtenerPorId(id);
            if (_mascota != null) mascota.Remove(_mascota); }
    }
}
