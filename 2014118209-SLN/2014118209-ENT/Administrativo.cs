using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT
{
    public class Administrativo : Empleado
    {
        public int AdministrativoId { get; set; }

        public string Nombre { get; set; }

        public int VentaId { get; set; }

        public Venta Venta { get; set; }
    }
}


