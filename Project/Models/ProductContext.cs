using Microsoft.EntityFrameworkCore;

namespace ProjectApi.Models;

public class ProductContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public ProductContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
    }
    public DbSet<Product> Products { get; set; }
}