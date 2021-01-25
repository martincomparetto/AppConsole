using System;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepositorio<Persona> repo;
            AlumnosRepo repoAlumnos = new AlumnosRepo();
            ProfesoresRepo repoProfesores = new ProfesoresRepo();
            string opcion = "";
            string opcionEntidad = "";

            do
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("A - Alumnos");
                Console.WriteLine("P - Profesores");
                Console.WriteLine("0 - Salir");
                opcionEntidad = Console.ReadLine();

                string textoMenu = "";
                if (opcionEntidad == "A")
                {
                    textoMenu = "Alumno";
                    // repo = (IRepositorio<Persona>)repoAlumnos;
                }
                else if (opcionEntidad == "P")
                {
                    textoMenu = "Profesor";
                    // repo = repoProfesores;
                }

                Console.WriteLine("1 - Agregar {0}", textoMenu);
                Console.WriteLine("2 - Lista {0}", textoMenu);
                Console.WriteLine("3 - Buscar {0}", textoMenu);
                Console.WriteLine("4 - Eliminar {0}", textoMenu);
                if (opcionEntidad == "A") Console.WriteLine("5 - Mostrar Legajo Alumno");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine(); // Valor del menu, ingresado por el usuario

                if (opcion == "1")
                {
                    try
                    {
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("DNI: ");
                        int dni = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Fecha de Nacimiento: ");
                        DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Domicilio: ");
                        string domicilio = Console.ReadLine();
                        Console.Write("Legajo: ");
                        string legajo = Console.ReadLine();
                        Console.Write("Celular: ");
                        string celular = Console.ReadLine();

                        repo.Agregar(new Alumno(nombre, dni, email, fechaNacimiento, domicilio, legajo, celular));
                    }
                    catch (System.Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
                else if (opcion == "2")
                {
                    foreach (var dato in repo.DevolverTodos())
                    {
                        Console.WriteLine("{0} {1} {2} {3}", dato.Nombre, dato.DNI, dato.Legajo, dato.Email);
                    }
                }
                else if (opcion == "3")
                {
                    try
                    {
                        Console.Write("DNI: ");
                        int dni = Convert.ToInt32(Console.ReadLine());
                        Alumno alumnoBuscado = repo.Buscar(dni);
                        Console.WriteLine("{0} {1} {2} {3}", alumnoBuscado.Nombre, alumnoBuscado.DNI, alumnoBuscado.Legajo, alumnoBuscado.Email);
                    }
                    catch (System.Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
                else if (opcion == "4")
                {
                    try
                    {
                        Console.Write("DNI: ");
                        int dni = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Esta seguro de eliminar el alumno? (S/N)");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "S")
                        {
                            repo.Eliminar(dni);
                        }
                    }
                    catch (System.Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
                else if (opcion == "5")
                {
                    try
                    {
                        Console.Write("DNI: ");
                        int dni = Convert.ToInt32(Console.ReadLine());
                        string legajo = repo.DevolverLegajo(dni);
                        Console.WriteLine("El legajo es {0}", legajo);
                    }
                    catch (System.Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
                else if (opcion == "0")
                {
                    Console.WriteLine("Hasta luego");
                }
                else
                {
                    Console.WriteLine("Opción incorrecta");
                }
            } while (opcion != "0");
        }
    }
}
