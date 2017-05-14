using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class EncomiendaConfiguration:EntityTypeConfiguration<Encomienda>
    {
        public EncomiendaConfiguration()
        {
            //Table Configurations
            ToTable("Encomienda");

            HasKey(c => c.EncomiendaId);


            Property(c => c.Nombre).HasMaxLength(255);
                        
        }
    }
}
