using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class VentaConfiguration : EntityTypeConfiguration<Venta>
    {
        public VentaConfiguration()
        {
            //Table Configurations
            ToTable("Venta");

            HasKey(a => a.VentaId);

            Property(a => a.Descripcion).HasMaxLength(255);

            

        }
    }
}
