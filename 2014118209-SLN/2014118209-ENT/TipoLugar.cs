namespace _2014118209_ENT
{
    public class TipoLugar
    {
        public int TipoLugarId { get; set; }

        public string Descripcion { get; set; }

        public int LugarViajeId { get; set; }

        public LugarViaje LugarViaje { get; set; }
    }
}