//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class FACTURACION
    {
        public FACTURACION()
        {
            this.DETALLE_FACTURACION = new HashSet<DETALLE_FACTURACION>();
        }
    
        public decimal IDFACTURACION { get; set; }
        public Nullable<decimal> IDSOLICLIQ { get; set; }
    
        public virtual ICollection<DETALLE_FACTURACION> DETALLE_FACTURACION { get; set; }
        public virtual FORMULARIO_LIQUIDACION FORMULARIO_LIQUIDACION { get; set; }
    }
}
