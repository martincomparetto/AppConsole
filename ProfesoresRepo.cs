using System;
using System.Collections.Generic;

namespace AppConsole
{
    public class ProfesoresRepo : RepositorioBase<Profesor>
    {
        public ProfesoresRepo()
        {
            Datos.Add(new Profesor("Jirafales", 11870520, "1155665146", "jirafales@gmail.com"));
            Datos.Add(new Profesor("Matilda", 30582233, "3416555856", "matilda@gmail.com"));
            Datos.Add(new Profesor("Edna", 11874456, "225663632", "edna@gmail.com"));
        }
    }
}