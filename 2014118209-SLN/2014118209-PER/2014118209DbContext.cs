﻿using _2014118209_ENT;
using _2014118209_PER.EntitiesConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER
{
    public class _2014118209DbContext:DbContext
    {
        public DbSet<Administrativo> Administrativos { get; set; }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Encomienda> Encomiendas { get; set; }
        public DbSet<LugarViaje> LugarViajes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<TipoComprobante> TipoComprobantes { get; set; }
        public DbSet<TipoLugar> TipoLugares { get; set; }
        public DbSet<TipoPago> TipoPagos { get; set; }
        public DbSet<TipoTripulación> TipoTripulaciones { get; set; }
        public DbSet<TipoViaje> TipoViajes { get; set; }
        public DbSet<Transporte> Transportes { get; set; }
        public DbSet<Tripulación> Tripulaciones { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdministrativoConfiguration());
            modelBuilder.Configurations.Add(new BusConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new EncomiendaConfiguration());
            modelBuilder.Configurations.Add(new LugarViajeConfiguration());
            modelBuilder.Configurations.Add(new ServicioConfiguration());
            modelBuilder.Configurations.Add(new TipoComprobanteConfiguration());
            modelBuilder.Configurations.Add(new TipoLugarConfiguration());
            modelBuilder.Configurations.Add(new TipoPagoConfiguration());
            modelBuilder.Configurations.Add(new TipoTripulacionConfiguration());
            modelBuilder.Configurations.Add(new TipoViajeConfiguration());
            modelBuilder.Configurations.Add(new TransporteConfiguration());
            modelBuilder.Configurations.Add(new TripulacionConfiguration());
            modelBuilder.Configurations.Add(new VentaConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
