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
        public async Task<List<Article>> GetAllAsync() // какие данные нужны из бд (в этом случае все)
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Article?> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task CreateAsync(string title, string content, string email) // создать статью
        {
            var article = new Article
            {
                Title = title,
                Content = content,
                Status = ArticleStatus.Pending,
                AuthorEmail = email,
                ImageUrl = "/images/default.jpg"
            };

            await _repo.AddAsync(article);
        }

        public async Task<List<Article>> GetApprovedAsync() // получить все принятые статьи
        {
            return await _repo.GetApprovedAsync();
        }

        public async Task<List<Article>> GetPendingAsync()
        {
            return await _repo.GetPendingAsync();
        }


    }
}
