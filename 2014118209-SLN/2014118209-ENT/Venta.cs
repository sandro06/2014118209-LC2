using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT
{
    public class Venta
    {
            public int VentaId { get; set; }

            public string Descripcion { get; set; }

            public List<Administrativo> Administrativos { get; set; }
            public List<Cliente> Clientes { get; set; }
            public List<Servicio> Servicios { get; set; }
            public List<TipoPago> TipoPagos { get; set; }
            public List<TipoComprobante> TipoComprobantes { get; set; }

            public Venta()
                {
                    Administrativos = new List<Administrativo>();
                    Clientes = new List<Cliente>();
                    Servicios = new List<Servicio>();
                    TipoPagos = new List<TipoPago>();
                    TipoComprobantes = new List<TipoComprobante>();
                    
                }

           

           
                
            

    }
}
