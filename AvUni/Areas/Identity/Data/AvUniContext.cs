using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AVC.Models;
using System.Linq;
using AvUni.Models;

namespace AvUni.Data;

public class AvUniContext : IdentityDbContext<IdentityUser>
{
    public AvUniContext(DbContextOptions<AvUniContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public static class DbInitializer
    {
        public static void Initialize(AvUniContext context)
        {
            context.Database.EnsureCreated();

            if(context.Product.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product{Title="Jacket - Sizes 12 - 14 years", Category="Optional", Price="$96.00"},
                new Product{Title="Jacket - Sizes xxs - xs", Category="Optional", Price="$110.00"},
                new Product{Title="Jacket - Sizes Small - 5Xl", Category="Optional", Price="$135.00"},
                new Product{Title="Scarf", Category="Optional", Price="$28.50"},
                new Product{Title="Cap", Category="Optional", Price="$23.00"},
                new Product{Title="Long black socks with double white strip", Category="Optional", Price="$18.00"},
                new Product{Title="Tie", Category="Optional", Price="$29.00"},
                new Product{Title="Blazer", Category="Optional", Price="$220.00"},
                new Product{Title="", Category="Junior", Price=""},
                new Product{Title="", Category="Junior", Price=""},
                new Product{Title="", Category="Junior", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
                new Product{Title="", Category="", Price=""},
            };
        }
    }
    public DbSet<AVC.Models.Order>? Order { get; set; }

    public DbSet<AVC.Models.Product>? Product { get; set; }

    public DbSet<AVC.Models.OrderProduct>? OrderProduct { get; set; }
}
