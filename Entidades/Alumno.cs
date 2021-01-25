using System;

namespace AppConsole
{
    public class Alumno : Persona
    {
        public DateTime FechaNacimiento;
        public string Domicilio;
        public string Legajo;

        public Alumno()
        {
            
        }

        public Alumno(string nombre, int dni, string email, DateTime fechaNacimiento, string domicilio, string legajo, string celular = "Sin ingresar")
        {
            Nombre = nombre;
            DNI = dni;
            Celular = celular;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            Domicilio = domicilio;
            Legajo = legajo;
        }
    }
}