using InventorySystem.Models;
using InventorySystem.Seeders;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem
{
    public class InventorySystemDbContext : DbContext
    {
        public InventorySystemDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            if (!Database.IsInMemory())
            {
                ItemSeeder.Seed(modelBuilder);
            }

            modelBuilder.Entity<Item>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Item>()
                .Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Item>()
                .Property(e => e.Description)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Item>()
                .Property(e=>e.Category)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Item>()
                .Property(e => e.Stock)
                .IsRequired();
            modelBuilder.Entity<Item>()
                .Property(e=>e.CreatedAt)
                .IsRequired();
            modelBuilder.Entity<Item>()
                .Property(e => e.UpdatedAt)
                .IsRequired();
        }
    }
}
