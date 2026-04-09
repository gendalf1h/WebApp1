using WebApp1.Models;
using WebApp1.Repository;
namespace WebApp1.Service
{
    public class ProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

    }
}
