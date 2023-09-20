using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Entities
{
    public partial class OrderingContext : DbContext
    {
        public OrderingContext()
        {
        }
        public OrderingContext(DbContextOptions<OrderingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<ItemPrinters> ItemPrinters { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public DbSet<User> User { get; set; }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-JDMM5F1\\MSSQLSERVER01; Database=Ordering; Trusted_Connection=True; Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.ToTable("categories");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ItemPrinters>(entity =>
            {
                entity.Property(e => e.Printer).HasMaxLength(50);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemPrinters)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemPrinters_Items");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Items_categories");
            });

            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItems_Items");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItems_Orders");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.TaxPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 5)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
