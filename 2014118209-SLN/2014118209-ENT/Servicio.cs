namespace _2014118209_ENT
{
    public class Servicio
    {
        public int ServicioId { get; set; }

        public string Nombre { get; set; }

        public int VentaId { get; set; }

        public Venta Venta { get; set; }

    }
}