﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuilderWebSite.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BuilderWebSiteEntities : DbContext
    {
        public BuilderWebSiteEntities()
            : base("name=BuilderWebSiteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<OurServices> OurServices { get; set; }
        public virtual DbSet<Sliders> Sliders { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<RecentProjects> RecentProjects { get; set; }
        public virtual DbSet<References> References { get; set; }
        public virtual DbSet<OurServiceImages> OurServiceImages { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<ContactForm> ContactForm { get; set; }
    }
}
