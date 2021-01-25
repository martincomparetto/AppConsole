using System;
using System.Collections.Generic;

namespace AppConsole
{
    public class AlumnosRepo : RepositorioBase<Alumno>
    {
        public AlumnosRepo()
        {
            Datos.Add(new Alumno("Martin", 29047312, "martin@gmail.com", new DateTime(1981, 11, 23), "Por ahi 200", "21-001", "3416168668"));
            Datos.Add(new Alumno("Analia", 30256256, "ana@gmail.com", new DateTime(1995, 11, 23), "Por ahi 200", "21-002", "3416168668"));
            Datos.Add(new Alumno("Josefina", 35654654, "jose@gmail.com", new DateTime(1998, 11, 23), "Por ahi 200", "21-003", "3416168668"));
        }

        public string DevolverLegajo(int dni)
        {
            Alumno alumnoDevolver = BuscarEntidad(dni);
            if (alumnoDevolver != null)
            {
                return alumnoDevolver.Legajo;
            }
            else
            {
                throw new Exception("No se encontró el alumno");
            }
        }
    }
}