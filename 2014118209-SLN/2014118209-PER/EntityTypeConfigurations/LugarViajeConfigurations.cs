using _2014118209_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntityTypeConfigurations
{
    public class LugarViajeConfiguration : EntityTypeConfiguration<LugarViaje>
    {
        public LugarViajeConfiguration()
        {
            //Table Configurations
            ToTable("LugarViajes");
            HasKey(c => c.LugarViajeId);
            Property(c => c.Descripcion)
                .IsRequired()
                .HasMaxLength(255);

        }
    }
}
