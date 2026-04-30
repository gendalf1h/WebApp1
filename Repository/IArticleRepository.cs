using Microsoft.EntityFrameworkCore;
using WebApp1.Data;
using WebApp1.Models;
namespace WebApp1.Repository
{
    public interface IArticleRepository
    {
        Task<List<Article>> GetAllAsync();
        Task<Article?> GetByIdAsync(int id);

        //Task CreateAsync(Article article);
        //Task<List<Article>> GetAllApprovedAsync();

        Task AddAsync(Article article); // добавить статью 
        Task<List<Article>> GetApprovedAsync(); // получить принятую статью
        Task<List<Article>> GetPendingAsync(); // получить статью на проверке

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

        //public async Task CreateAsync(Article article)
        //{
        //    article.IsApproved = false;
        //    article.CreateAt = DateTime.UtcNow;

        //    await _context.AddAsync(article);  
        //}

        //public async Task<List<Article>> GetAllApprovedAsync()
        //{
        //    return await _context.GetApprovedAsync();
        //}



        public async Task AddAsync(Article article)
        {
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Article>> GetApprovedAsync()
        {
            return await _context.Articles.Where(x => x.Status == ArticleStatus.Approved).ToListAsync();
        }

        public async Task<List<Article>> GetPendingAsync()
        {
            return await _context.Articles.Where(x => x.Status == ArticleStatus.Pending).ToListAsync();
        }


    }
}