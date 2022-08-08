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
                new Product{Title="Junior pleated skirt", Category="Junior", Price="$69.00"},
                new Product{Title="Long skirt", Category="Junior", Price="$80.00"},
                new Product{Title="Grey shorts", Category="Junior", Price="$50.00"},
                new Product{Title="Pinstripe shorts", Category="Junior", Price="$59.00"},
                new Product{Title="Grey trousers", Category="Junior", Price="$66.00"},
                new Product{Title="Polo shirt - short sleeve", Category="Junior", Price="$35.00"},
                new Product{Title="Polo shirt - long sleeve", Category="Junior", Price="$40.00"},
                new Product{Title="Black/white jersey", Category="Junior", Price="$99.00"},
                new Product{Title="PE top", Category="Junior", Price="$60.00"},
                new Product{Title="PE shorts", Category="Junior", Price="$45.00"},
                new Product{Title="50 denier pantihose", Category="Junior", Price="$9.00"},
                new Product{Title="Black ankle socks", Category="Junior", Price="$8.50"},
                new Product{Title="Senior straight short skirt", Category="Senior", Price="$69.00"},
                new Product{Title="Long skirt", Category="Senior yr 11 - 12", Price=""},
                new Product{Title="Grey shorts", Category="Senior yr 11 - 12", Price=""},
                new Product{Title="Pinstripe Shorts", Category="Senior yr 11 - 12", Price="$59.00"},
                new Product{Title="Grey trousers", Category="Senior yr 11 - 12", Price="$66.00"},
                new Product{Title="White senior blouse - short sleeved", Category="Senior yr 11 - 12", Price="$56.00"},
                new Product{Title="White senior blouse - long sleeved", Category="Senior yr 11 - 12", Price="$59.00"},
                new Product{Title="Polo shirt - short sleeve", Category="Senior yr 11 - 12", Price="$35.00"},
                new Product{Title="Polo shirt - long sleeve", Category="Senior yr 11 - 12", Price="$40.00"},
                new Product{Title="Black/White jersey", Category="Senior yr 11 - 12", Price="$99.00"},
                new Product{Title="50 denier pantihose", Category="Senior yr 11 - 12", Price="$9.00"},
                new Product{Title="Black ankle socks", Category="Senior yr 11 - 12", Price="$8.50"},
                new Product{Title="Senior straight short skirt", Category="Senior yr 13", Price="$69.00"},
                new Product{Title="Long skirt", Category="Senior yr 13", Price="$80.00"},
                new Product{Title="Black year 13 shorts", Category="Senior yr 13", Price="$50.00"},
                new Product{Title="Black year 13 trousers", Category="Senior yr 13", Price="$66.00"},
                new Product{Title="White senior blouse - short sleeved", Category="Senior yr 13", Price="$56.00"},
                new Product{Title="White senior blouse - long sleeved", Category="Senior yr 13", Price="$59.00"},
                new Product{Title="White year 13 shirt (short sleeved)", Category="Senior yr 13", Price="$50.00"},
                new Product{Title="White year 13 shirt (long sleeved)", Category="Senior yr 13", Price="$51.00"},
                new Product{Title="Black year 13 jersey", Category="Senior yr 13", Price="$99.00"},
                new Product{Title="50 denier pantihose", Category="Senior yr 13", Price="$9.00"},
                new Product{Title="Black ankle socks", Category="Senior yr 13", Price="$8.50"},
            };
        }
    }
    public DbSet<AVC.Models.Order>? Order { get; set; }

    public DbSet<AVC.Models.Product>? Product { get; set; }

    public DbSet<AVC.Models.OrderProduct>? OrderProduct { get; set; }
}
