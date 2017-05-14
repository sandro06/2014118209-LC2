using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class AdministrativoConfiguration:EntityTypeConfiguration<Administrativo>
    {
        public AdministrativoConfiguration()
        {
            //Table Configurations
            ToTable("Administrativo");


            HasKey(c => c.AdministrativoId);


            Property(c => c.Nombre).HasMaxLength(255);

            //Relacions Configurations
            HasRequired(c => c.Venta)
                .WithMany(c => c.Administrativos);
        }
        
    }
}
