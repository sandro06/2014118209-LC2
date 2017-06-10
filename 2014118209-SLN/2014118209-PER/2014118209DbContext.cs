using _2014118209_ENT.Entities;
using _2014118209_PER.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER
{
    public class _2014118209DbContext : DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Administrativo> Administrativos { get; set; }
        public DbSet<Tripulacion> Tripulaciones { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }

        public DbSet<LugarViaje> LugarViajes { get; set; }
        public _2014118209DbContext()
            : base("Transportes_Sandro")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new BusConfiguration());

            modelBuilder.Configurations.Add(new VentaConfiguration());

            modelBuilder.Configurations.Add(new ServicioConfiguration());

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new LugarViajeConfiguration());

            //modelBuilder.Entity<Servicio>().ToTable("Servicios");
            //modelBuilder.Entity<Servicio>().HasKey(a => a.ServicioId);

            //modelBuilder.Entity<Servicio>().Property(a => a.ServicioId)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //modelBuilder.Entity<Servicio>().Property(v => v.Tipo)
            //    .IsRequired()
            //    .HasMaxLength(255);
            //modelBuilder.Entity<Servicio>().Map<Encomienda>(m => m.Requires("Discriminat").HasValue("Encomienda"));
            //modelBuilder.Entity<Servicio>().Map<Transporte>(m => m.Requires("Discriminat").HasValue("Transporte"));
            base.OnModelCreating(modelBuilder);

        }
    }
}
