using System;
using System.Collections.Generic;

namespace _2014118209_ENT
{
    public class Tripulación : Empleado
    {
        public int TripulacionId { get; set; }
        public DateTime FechaRegistro { get; set; }

        public List<TipoTripulación> TipoTripulaciones { get; set; }
        public int BusId { get; set; }
        public Bus Bus { get; set; }

        public Tripulación()
        {
            TipoTripulaciones = new List<TipoTripulación>();
        }
    }
}