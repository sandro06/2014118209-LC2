using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class TransporteConfiguration:EntityTypeConfiguration<Transporte>
    {
        public TransporteConfiguration()
        {
            //Table Configurations
            ToTable("Transporte");

            HasKey(a => a.TransporteId);

            Property(a => a.Descripcion).HasMaxLength(255);
            
        }
    }
}
