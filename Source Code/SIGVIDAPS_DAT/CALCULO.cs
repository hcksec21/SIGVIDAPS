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
    
    public partial class CALCULO
    {
        public CALCULO()
        {
            this.DETALLE_CALCULO = new HashSet<DETALLE_CALCULO>();
        }
    
        public decimal IDCALCULO { get; set; }
        public Nullable<decimal> IDFORMANTICIPO { get; set; }
    
        public virtual FORMULARIO__ANTICIPO FORMULARIO__ANTICIPO { get; set; }
        public virtual ICollection<DETALLE_CALCULO> DETALLE_CALCULO { get; set; }
    }
}
