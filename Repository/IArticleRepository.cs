using Microsoft.EntityFrameworkCore;
using WebApp1.Data;
using WebApp1.Models;
namespace WebApp1.Repository
{
    public interface IArticleRepository 
    {
        Task<List<Article>> GetAllAsync();
        Task<Article?> GetByIdAsync(int id); 
    }

    public class ArticleRepository : IArticleRepository 
    {
        private readonly AppDbContext _context;

        public ArticleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Article>> GetAllAsync() // получаем все данные из бд
        {
            return await _context.Articles.ToListAsync();
        }

        public async Task<Article?> GetByIdAsync(int id)
        {
            return await _context.Articles.FirstOrDefaultAsync(p => p.Id == id);
        }

    }
}
