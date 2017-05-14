using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class TripulacionConfiguration:EntityTypeConfiguration<Tripulación>
    {
        public TripulacionConfiguration()
        {
            //Table Configurations
            ToTable("Tripulacion");


            HasKey(c => c.TripulacionId);


            Property(c => c.DNI).HasMaxLength(255);

            //Relacions Configurations
            HasRequired(c => c.Bus)
                .WithMany(c => c.Tripulaciones);
        }
        
    }
}
