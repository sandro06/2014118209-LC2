using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT.Entities
{
    public class Tripulacion : Empleado
    {
        public int BusId { get; set; }
        public TipoTripulacion TipoTripulacion { get; set; }
        public Bus Bus { get; set; }
    }
}
