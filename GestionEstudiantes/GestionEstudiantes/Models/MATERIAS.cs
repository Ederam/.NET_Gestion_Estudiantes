//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionEstudiantes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MATERIAS
    {
        public MATERIAS()
        {
            this.CLASES = new HashSet<CLASES>();
            this.PROFESORES = new HashSet<PROFESORES>();
        }
    
        public int ID_MATERIA { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<int> CREDITOS { get; set; }
    
        public virtual ICollection<CLASES> CLASES { get; set; }
        public virtual ICollection<PROFESORES> PROFESORES { get; set; }
    }
}
