using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT.Entities
{
    public class LugarViaje
    {
        public int LugarViajeId { get; set; }
        public string Descripcion { get; set; }
        public TipoLugar TipoLugar { get; set; }
        public List<Servicio> Servicios { get; set; }

    }
}
