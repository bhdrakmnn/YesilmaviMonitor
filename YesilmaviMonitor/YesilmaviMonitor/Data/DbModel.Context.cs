﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YesilmaviMonitor.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class b2bdebugEntities : DbContext
    {
        public b2bdebugEntities()
            : base("name=b2bdebugEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sync_config> sync_config { get; set; }
        public virtual DbSet<sync_log> sync_log { get; set; }
        public virtual DbSet<sync_status> sync_status { get; set; }
        public virtual DbSet<setup> setup { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<virtualpos_trans> virtualpos_trans { get; set; }
        public virtual DbSet<order_details> order_details { get; set; }
        public virtual DbSet<clcard> clcard { get; set; }
        public virtual DbSet<items> items { get; set; }
        public virtual DbSet<slsman> slsman { get; set; }
        public virtual DbSet<virtualpos> virtualpos { get; set; }
    }
}