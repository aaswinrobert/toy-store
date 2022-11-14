using MVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data
{
    
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToyItems>().HasKey(ac => new
            {
                ac.ShopID,
                ac.ToyID
            });

            modelBuilder.Entity<ToyItems>().HasOne(m => m.Toys).WithMany(ac => ac.ToyItems).HasForeignKey(m => m.ToyID);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ToyItems>().HasOne(m => m.Shops).WithMany(ac => ac.ToyItems).HasForeignKey(m => m.ShopID);
            base.OnModelCreating(modelBuilder);

            
        }

        public DbSet<Shops> Shops { get;set; }

        public DbSet<Toys> Toys { get; set; }

        public DbSet<ToyItems> ToyItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
