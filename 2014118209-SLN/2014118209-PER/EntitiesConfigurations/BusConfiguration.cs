using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class BusConfiguration:EntityTypeConfiguration<Bus>
    {
        public BusConfiguration()
        {
            //Table Configuration
            ToTable("Bus");

            HasKey(c => c.BusId);

            Property(c => c.Marca).HasMaxLength(255);
            //Ralations Configuration
            HasRequired(c => c.Encomienda)
                .WithRequiredPrincipal(c => c.Bus);
            
        }
        
    }
}
