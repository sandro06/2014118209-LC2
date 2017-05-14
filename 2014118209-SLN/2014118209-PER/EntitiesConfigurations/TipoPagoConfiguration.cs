using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class TipoPagoConfiguration:EntityTypeConfiguration<TipoPago>
    {
        public TipoPagoConfiguration()
        {
            //Table Configurations
            ToTable("TipoPago");


            HasKey(c => c.TipoPagoId);


            Property(c => c.Descripcion).HasMaxLength(255);

            //Relacions Configurations
            HasRequired(c => c.Venta)
                .WithMany(c => c.TipoPagos);
        }
    }
}
