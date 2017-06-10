using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT.Entities
{
    public class Transporte : Servicio
    {

        public int ClienteId { get; set; }
        public TipoViaje TipoViaje { get; set; }
        public Cliente Cliente { get; set; }

        public override void Service()
        {

            Cliente _Cliente = new Cliente();

            LugarViaje _LugarViaje = new LugarViaje();
            Console.WriteLine("Transporte");
            Console.WriteLine("------------------------------------------------------------------------------");

            for (int i = 0; i < 3; i++)
            {


                Console.WriteLine("" + _Cliente.Nombres + " " + _Cliente.Apellidos + "  Tipo de Viaje: " + "   Destino:" + _LugarViaje.Descripcion);
            }

            Console.WriteLine("------------------------------------------------------------------------------");
        }

    }
}
