using Microsoft.EntityFrameworkCore;
using WebApp1.Models;

namespace WebApp1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)  
            : base(options) { }

    }
}
