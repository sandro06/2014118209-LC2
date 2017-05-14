using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class LugarViajeConfiguration:EntityTypeConfiguration<LugarViaje>
    {
        public LugarViajeConfiguration()
        {
            //Table Configurations
            ToTable("LugarViaje");


            HasKey(c => c.LugarViajeId);


            Property(c => c.Nombre).HasMaxLength(255);

            //Relacions Configurations
            HasRequired(c => c.Transporte)
                .WithMany(c => c.LugarViajes);

            HasRequired(c => c.Encomienda)
                .WithMany(c => c.LugarViajes);
        }
    }
}
