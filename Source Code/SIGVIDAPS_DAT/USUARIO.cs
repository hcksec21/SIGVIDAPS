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
