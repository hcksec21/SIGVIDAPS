﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIGVIDAPS_DAT
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SIGVIDAPS_entidades : DbContext
    {
        public SIGVIDAPS_entidades()
            : base("name=SIGVIDAPS_entidades")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CALCULO> CALCULOes { get; set; }
        public DbSet<CARGO> CARGOes { get; set; }
        public DbSet<COMBINACION_VIATICOS> COMBINACION_VIATICOS { get; set; }
        public DbSet<DETALLE_CALCULO> DETALLE_CALCULO { get; set; }
        public DbSet<DETALLE_FORMULARIO> DETALLE_FORMULARIO { get; set; }
        public DbSet<EMPLEADO> EMPLEADOes { get; set; }
        public DbSet<FACTURACION> FACTURACIONs { get; set; }
        public DbSet<FORMULARIO__ANTICIPO> FORMULARIO__ANTICIPO { get; set; }
        public DbSet<FORMULARIO_LIQUIDACION> FORMULARIO_LIQUIDACION { get; set; }
        public DbSet<MENU_PERFIL> MENU_PERFIL { get; set; }
        public DbSet<NIVEL> NIVELs { get; set; }
        public DbSet<OPCION_NIVEL> OPCION_NIVEL { get; set; }
        public DbSet<OPCIONES_VIATICOS> OPCIONES_VIATICOS { get; set; }
        public DbSet<PERFIL> PERFILs { get; set; }
        public DbSet<RUTA> RUTAs { get; set; }
        public DbSet<TIPO_TRANSPORTE> TIPO_TRANSPORTE { get; set; }
        public DbSet<USUARIO> USUARIOs { get; set; }
    }
}
