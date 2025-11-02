using API_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API_Project.DbContext
{
    public class APIContext : IdentityDbContext<ApplicationUser>
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed Categories
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", Description = "Electronic devices and gadgets" },
                new Category { Id = 2, Name = "Clothing", Description = "Fashion and apparel items" },
                new Category { Id = 3, Name = "Books", Description = "Books and educational materials" },
                new Category { Id = 4, Name = "Home & Kitchen", Description = "Home appliances and kitchen tools" },
                new Category { Id = 5, Name = "Sports", Description = "Sports equipment and accessories" }
            );

            // Seed Products
            builder.Entity<Product>().HasData(
                // Electronics
                new Product { Id = 1, Name = "Laptop HP ProBook", Description = "15.6 inch, Intel i5, 8GB RAM, 256GB SSD", Price = 15000.00M, CategoryId = 1 },
                new Product { Id = 2, Name = "iPhone 14 Pro", Description = "128GB, Space Black", Price = 35000.00M, CategoryId = 1 },
                new Product { Id = 3, Name = "Samsung TV 55 inch", Description = "4K Smart LED TV", Price = 12000.00M, CategoryId = 1 },
                new Product { Id = 4, Name = "Wireless Mouse", Description = "Logitech M185, 2.4GHz", Price = 250.00M, CategoryId = 1 },

                // Clothing
                new Product { Id = 5, Name = "Nike T-Shirt", Description = "Cotton, Size L, Black", Price = 350.00M, CategoryId = 2 },
                new Product { Id = 6, Name = "Adidas Running Shoes", Description = "Size 42, Blue and White", Price = 1200.00M, CategoryId = 2 },
                new Product { Id = 7, Name = "Levi's Jeans", Description = "Blue Denim, Size 32", Price = 800.00M, CategoryId = 2 },

                // Books
                new Product { Id = 8, Name = "Clean Code", Description = "By Robert C. Martin", Price = 450.00M, CategoryId = 3 },
                new Product { Id = 9, Name = "Design Patterns", Description = "Gang of Four", Price = 500.00M, CategoryId = 3 },
                new Product { Id = 10, Name = "The Pragmatic Programmer", Description = "Your Journey To Mastery", Price = 480.00M, CategoryId = 3 },

                // Home & Kitchen
                new Product { Id = 11, Name = "Blender 3-in-1", Description = "1000W, Stainless Steel", Price = 650.00M, CategoryId = 4 },
                new Product { Id = 12, Name = "Non-Stick Pan Set", Description = "5 pieces, Tefal", Price = 1500.00M, CategoryId = 4 },
                new Product { Id = 13, Name = "Coffee Maker", Description = "Nespresso, Automatic", Price = 2200.00M, CategoryId = 4 },

                // Sports
                new Product { Id = 14, Name = "Football - Adidas", Description = "Size 5, Official Match Ball", Price = 450.00M, CategoryId = 5 },
                new Product { Id = 15, Name = "Yoga Mat", Description = "6mm thickness, Anti-slip", Price = 280.00M, CategoryId = 5 },
                new Product { Id = 16, Name = "Dumbbells Set", Description = "2x5kg, Rubber Coated", Price = 550.00M, CategoryId = 5 }
            );
        }
    }


}

