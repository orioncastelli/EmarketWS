﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmarketWS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EMarktEntities : DbContext
    {
        public EMarktEntities()
            : base("name=EMarktEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CategoryEntity> CategoryEntities { get; set; }
        public virtual DbSet<ListEntity> ListEntities { get; set; }
        public virtual DbSet<NFCeEntity> NFCeEntities { get; set; }
        public virtual DbSet<ProductEntity> ProductEntities { get; set; }
        public virtual DbSet<StoreEntity> StoreEntities { get; set; }
        public virtual DbSet<UserEntity> UserEntities { get; set; }
        public virtual DbSet<UserScanEntity> UserScanEntities { get; set; }
    }
}
