using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class TipoComprobanteConfiguration:EntityTypeConfiguration<TipoComprobante>
    {
        public TipoComprobanteConfiguration()
        {
            //Table Configurations
            ToTable("TipoComprobante");


            HasKey(c => c.TipoComprobanteId);


            Property(c => c.Nombre).HasMaxLength(255);

            //Relacions Configurations
            HasRequired(c => c.Venta)
                .WithMany(c => c.TipoComprobantes);
        }
    }
}
