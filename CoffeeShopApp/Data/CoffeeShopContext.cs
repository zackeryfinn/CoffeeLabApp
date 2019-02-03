using CoffeeShopApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CoffeeShopApp.Data
{
   public class CoffeeShopContext : DbContext
        {

            public CoffeeShopContext() : base("CoffeeShopDB")
            {

            }

            public DbSet<Patrons> Patrons { get; set; }
            public DbSet<Items> Items { get; set; }
            
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    }