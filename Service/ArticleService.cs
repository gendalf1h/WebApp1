using WebApp1.Repository;
using WebApp1.Models;
namespace WebApp1.Service
{
    public class ArticleService
    {
        private readonly IArticleRepository _repo;

        public ArticleService(IArticleRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Article>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }
    }
}
