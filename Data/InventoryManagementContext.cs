using Microsoft.EntityFrameworkCore;
using SupplyManagementSystem.Models;

namespace SupplyManagementSystem.Data
{
    public class InventoryManagementContext : DbContext
    {
        public InventoryManagementContext(DbContextOptions<InventoryManagementContext> options): base(options)
        {

        }


        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Supplier>().ToTable("Suppliers");
        }

    }

    
}
