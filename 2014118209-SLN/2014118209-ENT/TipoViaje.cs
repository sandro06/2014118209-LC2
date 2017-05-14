using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT
{
    public class TipoViaje
    {
        public int TipoViajeId { get; set; }

        public string Descripcion { get; set; }

        public int TransoporteId { get; set; }

        public Transporte Transporte { get; set; }

    }
}
