using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAPI.Models
{
    public partial class ToyStoreDBContext : DbContext
    {
        public ToyStoreDBContext()
        {
        }

        public ToyStoreDBContext(DbContextOptions<ToyStoreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual DbSet<ShopsToy> ShopsToys { get; set; }
        public virtual DbSet<Toy> Toys { get; set; }
        public virtual DbSet<ToyItem> ToyItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=GOVINDEED;Database=ToyStoreDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasIndex(e => e.OrderId, "IX_OrderItems_OrderId");

                entity.HasIndex(e => e.OrderItemId, "IX_OrderItems_OrderItemId");

                entity.HasIndex(e => e.ToysId, "IX_OrderItems_ToysId");

                entity.Property(e => e.ToyId).HasColumnName("ToyID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.OrderItemNavigation)
                    .WithMany(p => p.InverseOrderItemNavigation)
                    .HasForeignKey(d => d.OrderItemId);

                entity.HasOne(d => d.Toys)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ToysId);
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.Property(e => e.Desc).IsRequired();

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ShopImageUrl)
                    .IsRequired()
                    .HasColumnName("ShopImageURL");
            });

            modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                entity.HasIndex(e => e.ToysId, "IX_ShoppingCartItems_ToysId");

                entity.HasOne(d => d.Toys)
                    .WithMany(p => p.ShoppingCartItems)
                    .HasForeignKey(d => d.ToysId);
            });

            modelBuilder.Entity<ShopsToy>(entity =>
            {
                entity.HasKey(e => new { e.ShopsId, e.ToysId });

                entity.HasIndex(e => e.ToysId, "IX_ShopsToys_ToysId");

                entity.HasOne(d => d.Shops)
                    .WithMany(p => p.ShopsToys)
                    .HasForeignKey(d => d.ShopsId);

                entity.HasOne(d => d.Toys)
                    .WithMany(p => p.ShopsToys)
                    .HasForeignKey(d => d.ToysId);
            });

            modelBuilder.Entity<Toy>(entity =>
            {
                entity.Property(e => e.ToyImageUrl).HasColumnName("ToyImageURL");
            });

            modelBuilder.Entity<ToyItem>(entity =>
            {
                entity.HasKey(e => new { e.ShopId, e.ToyId });

                entity.HasIndex(e => e.ToyId, "IX_ToyItems_ToyID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.ToyId).HasColumnName("ToyID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ToyItems)
                    .HasForeignKey(d => d.ShopId);

                entity.HasOne(d => d.Toy)
                    .WithMany(p => p.ToyItems)
                    .HasForeignKey(d => d.ToyId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
