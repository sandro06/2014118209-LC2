using _2014118209_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntityTypeConfigurations
{
    public class VentaConfiguration : EntityTypeConfiguration<Venta>
    {
        public VentaConfiguration()
        {
            ToTable("Ventas");
            HasKey(c => c.VentaId);

            HasRequired(c => c.Administrativo)
              .WithMany(c => c.Ventas).
              HasForeignKey(c => c.EmpleadoId);



            HasRequired(c => c.Cliente)
                .WithMany(c => c.Ventas)
                .HasForeignKey(c => c.ClienteId);
        }
    }
}
