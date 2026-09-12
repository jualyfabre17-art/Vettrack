using System;
using System.Collections.Generic;
using System.Text;
using Vettrack.Veterinarios;

namespace Vettrack.Repositorios
{
    public class IVeterinario: IRepositorio<Veterinario>
    {
        private List<Veterinario> veterinario = new List<Veterinario>();

        public void Agregar(Veterinario entidad) { }
        public Veterinario ObtenerPorId(int id) { return null; }
        public List<Veterinario> ObtenerTodos() { return veterinario; }
        public void Actualizar(Veterinario entidad) { }
        public void Eliminar(int id) { }
    }
}
