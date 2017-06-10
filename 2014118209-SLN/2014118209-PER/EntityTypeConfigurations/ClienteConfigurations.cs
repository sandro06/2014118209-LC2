using _2014118209_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntityTypeConfigurations
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            //Table Configurations
            ToTable("Clientes");
            HasKey(c => c.ClienteId);
            Property(c => c.Apellidos)
                .IsRequired()
                .HasMaxLength(255);
            HasMany(t => t.Transportes)
                .WithRequired(t => t.Cliente)
                .HasForeignKey(t => t.ClienteId);

        }
    }
}
