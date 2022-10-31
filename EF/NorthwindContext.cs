using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EF
{
    public class NorthwindContext : DbContext
    {
        const string ConnectionString = "host=localhost;db=Northwind;uid=postgres;pwd=magnus1131";

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            optionsBuilder.UseNpgsql(ConnectionString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnName("categoryid");
            modelBuilder.Entity<Category>().Property(x => x.Name).HasColumnName("categoryname");
            modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnName("description");

            modelBuilder.Entity<Product>().ToTable("products");
            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("productid");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("productname");
            modelBuilder.Entity<Product>().Property(x => x.CategoryId).HasColumnName("categoryid");

            modelBuilder.Entity<Order>().ToTable("orders");
            modelBuilder.Entity<Order>().Property(x => x.OrderId).HasColumnName("orderid");
            modelBuilder.Entity<Order>().Property(x => x.CustomerId).HasColumnName("customerid");
            modelBuilder.Entity<Order>().Property(x => x.EmployeeId).HasColumnName("employeeid");
            modelBuilder.Entity<Order>().Property(x => x.RequiredDate).HasColumnName("requireddate");
            modelBuilder.Entity<Order>().Property(x => x.OrderDate).HasColumnName("orderdate");
            modelBuilder.Entity<Order>().Property(x => x.ShipName).HasColumnName("shipname");
            modelBuilder.Entity<Order>().Property(x => x.ShipDate).HasColumnName("shippeddate");
            modelBuilder.Entity<Order>().Property(x => x.Freight).HasColumnName("freight");
            modelBuilder.Entity<Order>().Property(x => x.ShipAddress).HasColumnName("shipaddress");
            modelBuilder.Entity<Order>().Property(x => x.ShipCity).HasColumnName("shipcity");
            modelBuilder.Entity<Order>().Property(x => x.ShipPostalCode).HasColumnName("shippostalcode");
            modelBuilder.Entity<Order>().Property(x => x.ShipCountry).HasColumnName("shipcountry");

            modelBuilder.Entity<OrderDetail>().ToTable("orderdetails");
            modelBuilder.Entity<OrderDetail>().Property(x => x.OrderId).HasColumnName("orderid");
            modelBuilder.Entity<OrderDetail>().Property(x => x.ProductId).HasColumnName("productid");
            modelBuilder.Entity<OrderDetail>().Property(x => x.UnitPrice).HasColumnName("unitprice");
            modelBuilder.Entity<OrderDetail>().Property(x => x.Quantity).HasColumnName("quantity");
            modelBuilder.Entity<OrderDetail>().Property(x => x.Discount).HasColumnName("discount");



        }
    }
}