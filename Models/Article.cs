namespace WebApp1.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; } // заголовок статьи
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreateAt { get; set; }

    }
}
