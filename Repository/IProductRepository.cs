using System.Data.Entity;
using WebApp1.Data;
using WebApp1.Models;

namespace WebApp1.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
    }

    class ProductRepository : IProductRepository
    {
        private AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

    }
}
