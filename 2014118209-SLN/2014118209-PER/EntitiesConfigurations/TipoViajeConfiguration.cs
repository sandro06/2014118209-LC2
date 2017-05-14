using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class TipoViajeConfiguration:EntityTypeConfiguration<TipoViaje>
    {
        public TipoViajeConfiguration()
        {
            //Table Configurations
            ToTable("TipoViaje");


            HasKey(c => c.TipoViajeId);


            Property(c => c.Descripcion).HasMaxLength(255);

            //Relacions Configurations
            HasRequired(c => c.Transporte)
                .WithMany(c => c.TipoViajes);
        }
    }
}
