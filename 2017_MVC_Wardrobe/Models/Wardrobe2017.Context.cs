﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2017_MVC_Wardrobe.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Wardrobe2017Entities : DbContext
    {
        public Wardrobe2017Entities()
            : base("name=Wardrobe2017Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorty_Type> Categorty_Type { get; set; }
        public virtual DbSet<Wardrobe_Items> Wardrobe_Items { get; set; }
    }
}
