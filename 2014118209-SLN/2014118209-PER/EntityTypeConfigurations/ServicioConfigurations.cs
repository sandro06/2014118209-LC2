using _2014118209_ENT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntityTypeConfigurations
{
    public class ServicioConfiguration : EntityTypeConfiguration<Servicio>
    {
        public ServicioConfiguration()
        {
            //Table Configurations
            ToTable("Servicios");

            HasKey(c => c.ServicioId);
            Property(a => a.ServicioId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            //Relationship Configurations
            Map<Encomienda>(m => m.Requires("Discriminator").HasValue("Encomienda"));
            Map<Transporte>(m => m.Requires("Discriminator").HasValue("Transporte"));

            HasRequired(t => t.LugarViaje)
                .WithMany(t => t.Servicios)
                .HasForeignKey(t => t.LugarViajeId);

            HasRequired(e => e.Bus)
                .WithMany(e => e.Servicios)
                .HasForeignKey(e => e.BusId);

            HasRequired(r => r.Venta)
                .WithRequiredPrincipal(r => r.Servicio);

        }
    }
}
