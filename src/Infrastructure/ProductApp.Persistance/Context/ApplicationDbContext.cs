using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistance.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Pen", Value = 10, Quantity = 100 },
                new Product() { Id = Guid.NewGuid(), Name = "Paper", Value = 20, Quantity = 200 },
                new Product() { Id = Guid.NewGuid(), Name = "Book", Value = 30, Quantity = 300 });

            base.OnModelCreating(modelBuilder);
        }

    }
}
