using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT.Entities
{
    public class Bus
    {
        public int BusId { get; set; }
        public string Placa { get; set; }
        public List<Tripulacion> Tripulaciones { get; set; }
        public List<Servicio> Servicios { get; set; }


    }
}
