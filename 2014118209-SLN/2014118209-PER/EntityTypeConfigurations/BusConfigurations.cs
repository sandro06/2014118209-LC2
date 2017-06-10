using _2014118209_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntityTypeConfigurations
{
    public class BusConfiguration : EntityTypeConfiguration<Bus>
    {
        public BusConfiguration()
        {
            //Table Configurations
            ToTable("Buses");
            HasKey(c => c.BusId);
            Property(c => c.Placa)
                .IsRequired()
                .HasMaxLength(255);
            HasMany(t => t.Tripulaciones)
                .WithRequired(t => t.Bus)
                .HasForeignKey(t => t.BusId);


        }
    }
}
