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
    
    public partial class USUARIO
    {
        public decimal IDUSUARIO { get; set; }
        public Nullable<decimal> IDEMP { get; set; }
        public Nullable<decimal> IDPERFIL { get; set; }
        public string NOMBREUSUARIO { get; set; }
        public string CONTRASENAUSUARIO { get; set; }
        public Nullable<bool> ESTUSUARIO { get; set; }
    
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual PERFIL PERFIL { get; set; }
    }
}
