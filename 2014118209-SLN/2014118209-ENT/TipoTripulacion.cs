using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT
{
    public class TipoTripulación
    {
        public int TipoTripulacionId { get; set; }
        public string Descripcion { get; set; }

        public int TripulacionId { get; set; }

        public Tripulación Tripulacion { get; set; }
    }
}
