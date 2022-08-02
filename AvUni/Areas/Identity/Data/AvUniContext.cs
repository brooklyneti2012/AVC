using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AVC.Models;

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

    public DbSet<AVC.Models.Order>? Order { get; set; }

    public DbSet<AVC.Models.Product>? Product { get; set; }

    public DbSet<AVC.Models.OrderProduct>? OrderProduct { get; set; }
}
