using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using APICUSTOMER.Model;

namespace APICUSTOMER.Model
{
    public class DBContextAPI:DbContext
    {
        public DBContextAPI(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
             base.OnModelCreating(modelBuilder);


         }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
