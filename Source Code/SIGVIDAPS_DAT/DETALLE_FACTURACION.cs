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
    
    public partial class DETALLE_FACTURACION
    {
        public decimal IDDETALLEFAC { get; set; }
        public Nullable<decimal> IDFACTURACION { get; set; }
    
        public virtual FACTURACION FACTURACION { get; set; }
    }
}
