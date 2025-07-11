using Microsoft.EntityFrameworkCore;

namespace MyAspNetCoreWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ExampleModel> ExampleModels { get; set; }
        
        // Add other DbSet properties for your models here
    }
}