using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT
{
    public class Transporte : Servicio
    {
        public int TransporteId { get; set; }

        public string Descripcion { get; set; }

        public List<Cliente> Clientes { get; set; }

        public List<TipoViaje> TipoViajes { get; set; }

        public List<LugarViaje> LugarViajes { get; set; }

        private List<Bus> _Buses;

        public List<Bus> Buses
        {
            get
            {
                return _Buses;
            }
            set
            {
                if (value.Count == 2)
                    _Buses = value;
            }
        }
        
        public Transporte(List<Bus> buses)
        {
            Buses = buses;
        }
    }
}
