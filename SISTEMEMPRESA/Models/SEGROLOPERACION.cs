//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SISTEMEMPRESA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SEGROLOPERACION
    {
        public int IdSegRolOperacion { get; set; }
        public Nullable<int> IdSegModulo { get; set; }
        public Nullable<int> IdSegRol { get; set; }
        public Nullable<int> IdSegOperacion { get; set; }
        public string UsuarioIngreso { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public string UsuarioModificacion { get; set; }
        public System.DateTime FechaModificacion { get; set; }
    
        public virtual SEGMODULO SEGMODULO { get; set; }
        public virtual SEGOPERACION SEGOPERACION { get; set; }
        public virtual SEGROL SEGROL { get; set; }
    }
}
