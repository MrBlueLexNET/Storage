using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage.Models;

namespace Storage.Data
{
    public class StorageContext : DbContext
    {
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

        //public DbSet<Storage.Models.Product> Product { get; set; } = default!;
        public DbSet<Product> Product => Set<Product>();

        //SeedData simpel 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                   new Product { Id = 1, Name = "Titanic", Price = 10, Category = Classification.Compressed, OrderDate = DateTime.Parse("1997-02-25"), Shelf = "2.0F" },
                   new Product { Id = 2, Name = "Screem", Price = 10, Category = Classification.Radioactive, OrderDate = DateTime.Parse("2005-07-25"), Shelf = "2.0F"   },
                   new Product { Id = 3, Name = "The Shining", Price = 10, Category = Classification.Infectious, OrderDate = DateTime.Parse("1997-05-30"), Shelf = "2.0F"   },
                   new Product { Id = 4, Name = "300", Price = 10, Category = Classification.None, OrderDate = DateTime.Parse("2000-05-30"), Shelf = "2.0F" },
                   new Product { Id = 5, Name = "Interstellar", Price = 10, Category = Classification.Other, OrderDate = DateTime.Parse("2014-02-1"), Shelf = "2.0F" },
                   new Product { Id = 6, Name = "The Dark Knight", Price = 10, Category = Classification.Compressed, OrderDate = DateTime.Parse("2008-06-12"), Shelf = "2.0F" }
                );
        }

    }
}
