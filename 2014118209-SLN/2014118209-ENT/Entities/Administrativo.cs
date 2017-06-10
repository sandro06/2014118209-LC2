using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT.Entities
{
    public class Administrativo : Empleado
    {
        public string Area { get; set; }
        public string Cargo { get; set; }
        public List<Venta> Ventas { get; set; }
    }
}
