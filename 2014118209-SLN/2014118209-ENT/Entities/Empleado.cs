using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT.Entities
{
    public abstract class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

    }
}
