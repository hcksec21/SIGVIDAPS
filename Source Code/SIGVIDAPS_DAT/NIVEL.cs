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
    
    public partial class NIVEL
    {
        public NIVEL()
        {
            this.CARGOes = new HashSet<CARGO>();
            this.OPCION_NIVEL = new HashSet<OPCION_NIVEL>();
        }
    
        public decimal IDNIVEL { get; set; }
        public string COD_NIVEL { get; set; }
        public int NIVEL1 { get; set; }
    
        public virtual ICollection<CARGO> CARGOes { get; set; }
        public virtual ICollection<OPCION_NIVEL> OPCION_NIVEL { get; set; }
    }
}
