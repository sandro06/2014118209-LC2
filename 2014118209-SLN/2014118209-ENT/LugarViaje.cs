using System.Collections.Generic;

namespace _2014118209_ENT
{
    public class LugarViaje
    {
        public List<TipoLugar> TipoLugares { get; set; }

        public int LugarViajeId { get; set; }
        public string Nombre { get; set; }

        public int TransporteId { get; set; }

        public Transporte Transporte { get; set; }

        public int EncomiendaId { get; set; }

        public Encomienda Encomienda { get; set; }


    }
}
