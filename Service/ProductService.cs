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

        // метод для получение конкретных данных?

    }
}
