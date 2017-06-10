using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT.Entities
{
    public abstract class Servicio
    {
        public int ServicioId { get; set; }
        public int LugarViajeId { get; set; }
        public int BusId { get; set; }
        public Venta Venta { get; set; }
        public LugarViaje LugarViaje { get; set; }
        public Bus Bus { get; set; }
        public virtual void Service() { }
    }
}
