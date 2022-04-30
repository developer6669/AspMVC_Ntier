using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Insurance.DAL.Models.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("InsuranceDB")
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
            Configuration.AutoDetectChangesEnabled = true;
        }


        public DbSet<User> User { get; set; }
        public DbSet<UserInsurance> UserInsurance { get; set; }
        public DbSet<InsuranceType> InsuranceType { get; set; }
        
    }
}