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
    
    public partial class COMBINACION_VIATICOS
    {
        public COMBINACION_VIATICOS()
        {
            this.FORMULARIO__ANTICIPO = new HashSet<FORMULARIO__ANTICIPO>();
        }
    
        public decimal IDCOMBINACION { get; set; }
        public string NOMCOMBINACION { get; set; }
    
        public virtual ICollection<FORMULARIO__ANTICIPO> FORMULARIO__ANTICIPO { get; set; }
    }
}
