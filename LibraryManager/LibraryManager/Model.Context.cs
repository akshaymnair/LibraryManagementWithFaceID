﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManager
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UckLibMgrDbEntities : DbContext
    {
        public UckLibMgrDbEntities()
            : base("name=UckLibMgrDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Book> Books { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<LogRegister> LogRegisters { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
