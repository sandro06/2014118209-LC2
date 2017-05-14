using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class TipoTripulacionConfiguration:EntityTypeConfiguration<TipoTripulación>
    {
        public TipoTripulacionConfiguration()
        {
            //Table Configurations
            ToTable("TipoTripulacion");


            HasKey(c => c.TipoTripulacionId);


            Property(c => c.Descripcion).HasMaxLength(255);

            //Relacions Configurations
            HasRequired(c => c.Tripulacion)
                .WithMany(c => c.TipoTripulaciones);
        }
    }
}
