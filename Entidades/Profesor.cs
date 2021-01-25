namespace AppConsole
{
    public class Profesor : Persona
    {
        public Profesor(string nombre, int dni, string celular, string email)
        {
            Nombre = nombre;
            DNI = dni;
            Celular = celular;
            Email = email;
        }
    }
}
