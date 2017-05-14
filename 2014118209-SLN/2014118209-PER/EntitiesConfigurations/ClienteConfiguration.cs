using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class ClienteConfiguration: EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            //Table Configurations
            ToTable("Cliente");


            HasKey(c => c.ClienteId);


            Property(c => c.Nombre).HasMaxLength(255);

            //Relacions Configurations
            HasRequired(c => c.Venta)
                .WithMany(c => c.Clientes);

            HasRequired(c => c.Transporte)
                .WithMany(c => c.Clientes);
        }

    }
}
