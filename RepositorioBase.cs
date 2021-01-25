using System;
using System.Collections.Generic;

namespace AppConsole
{
    public class RepositorioBase<E> : IRepositorio<E>
    where E : Persona
    {
        public List<E> Datos = new List<E>();

        public void Agregar(E entidad)
        {
            if (entidad.Nombre == "")
            {
                throw new Exception("Debe ingresar el nombre");
            }
            if (entidad.DNI == 0)
            {
                throw new Exception("Debe ingresar el DNI");
            }
            if (entidad.Email == "")
            {
                throw new Exception("Debe ingresar un Email");
            }
            E entidadRepetida = BuscarEntidad(entidad.DNI);
            if (entidadRepetida != null)
            {
                throw new Exception("El DNI ya esta ingresado");
            }

            Datos.Add(entidad);
        }

        public E Buscar(int dni)
        {
            E entidad = BuscarEntidad(dni);
            if (entidad == null)
                throw new Exception("No se encontró el registro");

            return entidad;
        }

        public List<E> DevolverTodos()
        {
            return Datos;
        }

        public void Eliminar(int dni)
        {
            E entidadEliminar = BuscarEntidad(dni);
            if (entidadEliminar != null)
            {
                Datos.Remove(entidadEliminar);
            }
            else
            {
                throw new Exception("No se encontró el registro a eliminar");
            }
        }

        protected E BuscarEntidad(int dni)
        {
            foreach (var item in Datos)
            {
                if (item.DNI == dni)
                {
                    return item;
                }
            }
            return null;
        }
    }

}