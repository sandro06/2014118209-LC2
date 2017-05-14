namespace _2014118209_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prueba1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                        DNI = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.VentaId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 255),
                        VentaId = c.Int(nullable: false),
                        TransporteId = c.Int(nullable: false),
                        Transporte_ServicioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Transporte", t => t.Transporte_ServicioId)
                .ForeignKey("dbo.Venta", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId)
                .Index(t => t.Transporte_ServicioId);
            
            CreateTable(
                "dbo.Servicio",
                c => new
                    {
                        ServicioId = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 255),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioId)
                .ForeignKey("dbo.Venta", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId);
            
            CreateTable(
                "dbo.Bus",
                c => new
                    {
                        BusId = c.Int(nullable: false, identity: true),
                        Marca = c.String(maxLength: 255),
                        EncomiendaId = c.Int(nullable: false),
                        NumeroBuses = c.Int(nullable: false),
                        Transporte_ServicioId = c.Int(),
                    })
                .PrimaryKey(t => t.BusId)
                .ForeignKey("dbo.Transporte", t => t.Transporte_ServicioId)
                .Index(t => t.Transporte_ServicioId);
            
            CreateTable(
                "dbo.LugarViaje",
                c => new
                    {
                        LugarViajeId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 255),
                        TransporteId = c.Int(nullable: false),
                        EncomiendaId = c.Int(nullable: false),
                        Encomienda_ServicioId = c.Int(nullable: false),
                        Transporte_ServicioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LugarViajeId)
                .ForeignKey("dbo.Encomienda", t => t.Encomienda_ServicioId)
                .ForeignKey("dbo.Transporte", t => t.Transporte_ServicioId)
                .Index(t => t.Encomienda_ServicioId)
                .Index(t => t.Transporte_ServicioId);
            
            CreateTable(
                "dbo.TipoLugar",
                c => new
                    {
                        TipoLugarId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 255),
                        LugarViajeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoLugarId)
                .ForeignKey("dbo.LugarViaje", t => t.LugarViajeId, cascadeDelete: true)
                .Index(t => t.LugarViajeId);
            
            CreateTable(
                "dbo.TipoTripulacion",
                c => new
                    {
                        TipoTripulacionId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 255),
                        TripulacionId = c.Int(nullable: false),
                        Tripulacion_EmpleadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoTripulacionId)
                .ForeignKey("dbo.Tripulacion", t => t.Tripulacion_EmpleadoId)
                .Index(t => t.Tripulacion_EmpleadoId);
            
            CreateTable(
                "dbo.TipoViaje",
                c => new
                    {
                        TipoViajeId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 255),
                        TransoporteId = c.Int(nullable: false),
                        Transporte_ServicioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoViajeId)
                .ForeignKey("dbo.Transporte", t => t.Transporte_ServicioId)
                .Index(t => t.Transporte_ServicioId);
            
            CreateTable(
                "dbo.TipoComprobante",
                c => new
                    {
                        TipoComprobanteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 255),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoComprobanteId)
                .ForeignKey("dbo.Venta", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId);
            
            CreateTable(
                "dbo.TipoPago",
                c => new
                    {
                        TipoPagoId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 255),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoPagoId)
                .ForeignKey("dbo.Venta", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId);
            
            CreateTable(
                "dbo.Administrativo",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false),
                        AdministrativoId = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 255),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpleadoId)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoId)
                .ForeignKey("dbo.Venta", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.EmpleadoId)
                .Index(t => t.VentaId);
            
            CreateTable(
                "dbo.Encomienda",
                c => new
                    {
                        ServicioId = c.Int(nullable: false),
                        EncomiendaId = c.Int(nullable: false),
                        NumeroEncomienda = c.Int(nullable: false),
                        BusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioId)
                .ForeignKey("dbo.Servicio", t => t.ServicioId)
                .ForeignKey("dbo.Bus", t => t.ServicioId)
                .Index(t => t.ServicioId);
            
            CreateTable(
                "dbo.Transporte",
                c => new
                    {
                        ServicioId = c.Int(nullable: false),
                        TransporteId = c.Int(nullable: false),
                        Descripcion = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ServicioId)
                .ForeignKey("dbo.Servicio", t => t.ServicioId)
                .Index(t => t.ServicioId);
            
            CreateTable(
                "dbo.Tripulacion",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false),
                        TripulacionId = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        BusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpleadoId)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoId)
                .ForeignKey("dbo.Bus", t => t.BusId, cascadeDelete: true)
                .Index(t => t.EmpleadoId)
                .Index(t => t.BusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tripulacion", "BusId", "dbo.Bus");
            DropForeignKey("dbo.Tripulacion", "EmpleadoId", "dbo.Empleado");
            DropForeignKey("dbo.Transporte", "ServicioId", "dbo.Servicio");
            DropForeignKey("dbo.Encomienda", "ServicioId", "dbo.Bus");
            DropForeignKey("dbo.Encomienda", "ServicioId", "dbo.Servicio");
            DropForeignKey("dbo.Administrativo", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.Administrativo", "EmpleadoId", "dbo.Empleado");
            DropForeignKey("dbo.TipoPago", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.TipoComprobante", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.Servicio", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.Cliente", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.Cliente", "Transporte_ServicioId", "dbo.Transporte");
            DropForeignKey("dbo.TipoViaje", "Transporte_ServicioId", "dbo.Transporte");
            DropForeignKey("dbo.Bus", "Transporte_ServicioId", "dbo.Transporte");
            DropForeignKey("dbo.TipoTripulacion", "Tripulacion_EmpleadoId", "dbo.Tripulacion");
            DropForeignKey("dbo.LugarViaje", "Transporte_ServicioId", "dbo.Transporte");
            DropForeignKey("dbo.TipoLugar", "LugarViajeId", "dbo.LugarViaje");
            DropForeignKey("dbo.LugarViaje", "Encomienda_ServicioId", "dbo.Encomienda");
            DropIndex("dbo.Tripulacion", new[] { "BusId" });
            DropIndex("dbo.Tripulacion", new[] { "EmpleadoId" });
            DropIndex("dbo.Transporte", new[] { "ServicioId" });
            DropIndex("dbo.Encomienda", new[] { "ServicioId" });
            DropIndex("dbo.Administrativo", new[] { "VentaId" });
            DropIndex("dbo.Administrativo", new[] { "EmpleadoId" });
            DropIndex("dbo.TipoPago", new[] { "VentaId" });
            DropIndex("dbo.TipoComprobante", new[] { "VentaId" });
            DropIndex("dbo.TipoViaje", new[] { "Transporte_ServicioId" });
            DropIndex("dbo.TipoTripulacion", new[] { "Tripulacion_EmpleadoId" });
            DropIndex("dbo.TipoLugar", new[] { "LugarViajeId" });
            DropIndex("dbo.LugarViaje", new[] { "Transporte_ServicioId" });
            DropIndex("dbo.LugarViaje", new[] { "Encomienda_ServicioId" });
            DropIndex("dbo.Bus", new[] { "Transporte_ServicioId" });
            DropIndex("dbo.Servicio", new[] { "VentaId" });
            DropIndex("dbo.Cliente", new[] { "Transporte_ServicioId" });
            DropIndex("dbo.Cliente", new[] { "VentaId" });
            DropTable("dbo.Tripulacion");
            DropTable("dbo.Transporte");
            DropTable("dbo.Encomienda");
            DropTable("dbo.Administrativo");
            DropTable("dbo.TipoPago");
            DropTable("dbo.TipoComprobante");
            DropTable("dbo.TipoViaje");
            DropTable("dbo.TipoTripulacion");
            DropTable("dbo.TipoLugar");
            DropTable("dbo.LugarViaje");
            DropTable("dbo.Bus");
            DropTable("dbo.Servicio");
            DropTable("dbo.Cliente");
            DropTable("dbo.Venta");
            DropTable("dbo.Empleado");
        }
    }
}
