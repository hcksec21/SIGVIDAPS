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
    
    public partial class FORMULARIO__ANTICIPO
    {
        public FORMULARIO__ANTICIPO()
        {
            this.CALCULOes = new HashSet<CALCULO>();
            this.DETALLE_FORMULARIO = new HashSet<DETALLE_FORMULARIO>();
        }
    
        public decimal IDFORMANTICIPO { get; set; }
        public Nullable<decimal> IDCOMBINACION { get; set; }
        public Nullable<decimal> IDEMP { get; set; }
        public string NUMFORMANTICIPO { get; set; }
        public Nullable<System.DateTime> FECFORMANTICIPO { get; set; }
        public string CIUDADFORMANTICIPO { get; set; }
        public string UNIDADFORMANTICIPO { get; set; }
        public Nullable<System.DateTime> HORASALIDAFORMANTICIPO { get; set; }
        public Nullable<System.DateTime> FECHASALIDAFORMANTICIPO { get; set; }
        public Nullable<System.DateTime> HORALLEGADAFORMANTICIPO { get; set; }
        public Nullable<System.DateTime> FECHALLEGADAFORMANTICIPO { get; set; }
        public string DESCRIPCIONFORMANTICIPO { get; set; }
        public string BANCOFORMANTICIPO { get; set; }
        public string TIPOCUENTAFORMANTICIPO { get; set; }
        public string NUMCUENTAFORMANTICIPO { get; set; }
        public string ESTADOFORMANTICIPO { get; set; }
    
        public virtual ICollection<CALCULO> CALCULOes { get; set; }
        public virtual COMBINACION_VIATICOS COMBINACION_VIATICOS { get; set; }
        public virtual ICollection<DETALLE_FORMULARIO> DETALLE_FORMULARIO { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
    }
}
