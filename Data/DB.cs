using Microsoft.EntityFrameworkCore;
using WebApp1.Models;

namespace WebApp1.Data
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options)  : base(options) { }

        public DbSet<Product> Products { get; set; }



    }
}
