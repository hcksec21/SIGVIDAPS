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
    
    public partial class RUTA
    {
        public RUTA()
        {
            this.DETALLE_SOLICITUD = new HashSet<DETALLE_SOLICITUD>();
        }
    
        public decimal IDRUTA { get; set; }
        public string CODRUTA { get; set; }
        public string NOMRUTA { get; set; }
    
        public virtual ICollection<DETALLE_SOLICITUD> DETALLE_SOLICITUD { get; set; }
    }
}