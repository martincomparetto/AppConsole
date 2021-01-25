using System.Collections.Generic;

namespace AppConsole
{
    public interface IRepositorio<E>
    where E : Persona
    {
        void Agregar(E entidad);

        void Eliminar(int dni);

        E Buscar(int dni);

        List<E> DevolverTodos();
    }

    public interface IEntidad
    {
    }
}