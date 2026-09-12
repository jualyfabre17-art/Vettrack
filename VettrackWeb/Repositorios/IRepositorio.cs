using System;
using System.Collections.Generic;
using System.Text;

namespace Vettrack.Repositorios
{
    public interface IRepositorio<T>
    {
        void Agregar(T entidad);
        T ObtenerPorId(int id);
        List<T> ObtenerTodos();
        void Actualizar(T entidad);
        void Eliminar(int id);
    }
}
