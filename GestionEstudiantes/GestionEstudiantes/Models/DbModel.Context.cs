﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbModels : DbContext
    {
        public DbModels()
            : base("name=DbModels")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CLASES> CLASES { get; set; }
        public DbSet<ESTUDIANTES> ESTUDIANTES { get; set; }
        public DbSet<MATERIAS> MATERIAS { get; set; }
        public DbSet<PROFESORES> PROFESORES { get; set; }
    }
}
