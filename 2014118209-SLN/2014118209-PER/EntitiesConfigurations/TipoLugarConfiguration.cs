using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class TipoLugarConfiguration : EntityTypeConfiguration<TipoLugar>
    {
        public TipoLugarConfiguration()
        {
            //Table Configurations
            ToTable("TipoLugar");

            HasKey(c => c.TipoLugarId);


            Property(c => c.Descripcion).HasMaxLength(255);

            //Relacions Configurations
            HasRequired(t => t.LugarViaje)
                .WithMany(t => t.TipoLugares);
        }
    }
}
