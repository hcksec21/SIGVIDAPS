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
        public FACTURACION()
        {
            this.DETALLE_FACTURACION = new HashSet<DETALLE_FACTURACION>();
        }
    
        public decimal IDFACTURACION { get; set; }
        public Nullable<decimal> IDFORMLIQ { get; set; }
    
        public virtual ICollection<DETALLE_FACTURACION> DETALLE_FACTURACION { get; set; }
        public virtual FORMULARIO_LIQUIDACION FORMULARIO_LIQUIDACION { get; set; }
    }
}
