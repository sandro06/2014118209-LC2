//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2014118209_API.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventas
    {
        public int VentaId { get; set; }
        public int EmpleadoId { get; set; }
        public int ClienteId { get; set; }
        public int TipoComprobante { get; set; }
        public int TipoPago { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Empleados Empleados { get; set; }
        public virtual Servicios Servicios { get; set; }
    }
}