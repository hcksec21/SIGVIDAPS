﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
    
        public virtual DbSet<CALCULO> CALCULOes { get; set; }
        public virtual DbSet<CARGO> CARGOes { get; set; }
        public virtual DbSet<COMBINACION_VIATICOS> COMBINACION_VIATICOS { get; set; }
        public virtual DbSet<DETALLE_CALCULO> DETALLE_CALCULO { get; set; }
        public virtual DbSet<DETALLE_FACTURACION> DETALLE_FACTURACION { get; set; }
        public virtual DbSet<DETALLE_SOLICITUD> DETALLE_SOLICITUD { get; set; }
        public virtual DbSet<EMPLEADO> EMPLEADOes { get; set; }
        public virtual DbSet<ESTADO_SOLICITUD_ANTICIPO> ESTADO_SOLICITUD_ANTICIPO { get; set; }
        public virtual DbSet<FACTURACION> FACTURACIONs { get; set; }
        public virtual DbSet<NIVEL> NIVELs { get; set; }
        public virtual DbSet<OPCION_NIVEL> OPCION_NIVEL { get; set; }
        public virtual DbSet<OPCIONES_VIATICOS> OPCIONES_VIATICOS { get; set; }
        public virtual DbSet<RUTA> RUTAs { get; set; }
        public virtual DbSet<SOLICITUD__ANTICIPO> SOLICITUD__ANTICIPO { get; set; }
        public virtual DbSet<SOLICITUD_LIQUIDACION> SOLICITUD_LIQUIDACION { get; set; }
        public virtual DbSet<TIPO_TRANSPORTE> TIPO_TRANSPORTE { get; set; }
    }
}
