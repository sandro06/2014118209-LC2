using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int EmpleadoId { get; set; }
        public int ClienteId { get; set; }

        public TipoComprobante TipoComprobante { get; set; }
        public TipoPago TipoPago { get; set; }
        public Administrativo Administrativo { get; set; }
        public Cliente Cliente { get; set; }
        public Servicio Servicio { get; set; }


    }
}
