//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class FACTURACION
    {
        public decimal IDFACTURACION { get; set; }
        public Nullable<decimal> IDFORMLIQ { get; set; }
        public string PATHIMAGENFACTURA { get; set; }
        public Nullable<System.DateTime> FECHAFACTURA { get; set; }
        public string EMISORFACTURA { get; set; }
        public Nullable<decimal> MONTOFACTURA { get; set; }
    
        public virtual FORMULARIO_LIQUIDACION FORMULARIO_LIQUIDACION { get; set; }
    }
}
