using _2014118209_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.EntitiesConfigurations
{
    public class EmpleadoConfiguration:EntityTypeConfiguration<Empleado>
    {
        public EmpleadoConfiguration()
        {
            //Table Configurations
            ToTable("Empleado");


            HasKey(c => c.EmpleadoId);


            Property(c => c.DNI).HasMaxLength(255);
        }
    } 
        
}
