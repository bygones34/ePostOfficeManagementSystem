﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ePostOffice_5001.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class epostofficeEntities : DbContext
    {
        public epostofficeEntities()
            : base("name=epostofficeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBL_ORDER> TBL_ORDER { get; set; }
        public virtual DbSet<TBLCATEGORY> TBLCATEGORY { get; set; }
        public virtual DbSet<TBLUSER> TBLUSER { get; set; }
    }
}