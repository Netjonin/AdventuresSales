using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdventureWorksSales.Web.Models
{
    public partial class AdventureWorksSalesContext : DbContext
    {
        public AdventureWorksSalesContext()
        {
        }

        public AdventureWorksSalesContext(DbContextOptions<AdventureWorksSalesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<SalesOrder> SalesOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=AdventureWorksSales;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Class)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Color).HasMaxLength(15);

                entity.Property(e => e.DiscontinuedDate).HasColumnType("datetime");

                entity.Property(e => e.ListPrice).HasColumnType("money");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductLine)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.ProductNumber)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ProductSubcategoryId).HasColumnName("ProductSubcategoryID");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.SellEndDate).HasColumnType("datetime");

                entity.Property(e => e.SellStartDate).HasColumnType("datetime");

                entity.Property(e => e.Size).HasMaxLength(5);

                entity.Property(e => e.SizeUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.StandardCost).HasColumnType("money");

                entity.Property(e => e.Style)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Weight).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.WeightUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductCategoryId)
                    .HasColumnName("ProductCategoryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<SalesOrder>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CarrierTrackingNumber).HasMaxLength(25);

                entity.Property(e => e.LineTotal).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.SalesOrderDetailId)
                    .HasColumnName("SalesOrderDetailID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

                entity.Property(e => e.SpecialOfferId).HasColumnName("SpecialOfferID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.UnitPriceDiscount).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
