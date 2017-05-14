using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT
{
    public class Encomienda : Servicio
    {
        public int EncomiendaId { get; private set; }
        public int NumeroEncomienda { get; private set; }


        public List<LugarViaje> LugarViajes { get; set; }

        public int BusId { get; set; }
        public Bus Bus { get; set; }

        public Encomienda()
        {

        }
        public Encomienda(Bus bus)
        {
            Bus = bus;
        }
        public Encomienda(int encomiendaId)
        {
            EncomiendaId = encomiendaId;
        }

    }
}
