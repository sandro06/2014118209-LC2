using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT
{
    public class Bus
    {
        public int BusId { get; set; }
        public string Marca { get; set; }
        
        private List<Tripulación> _Tripulaciones;
        public int EncomiendaId { get; set; }
        public Encomienda Encomienda { get; set; }
        public List<Tripulación> Tripulaciones
        {
            get
            {
                return _Tripulaciones;
            }
            set
            {
                if (value.Count == 4)
                    _Tripulaciones = value;
            }

        }

        public Bus(List<Tripulación> tripulaciones)
        {
            Tripulaciones = tripulaciones;
        }
        public int NumeroBuses { get; private set; }

        public Bus(int numeroBuses)
        {
            NumeroBuses = numeroBuses;
        }

    }
}
