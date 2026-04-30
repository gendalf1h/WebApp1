using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp1.Models
{
    public enum ArticleStatus
    {
        Pending, // на проверке = 0 
        Approved, // опубликована = 1
        Rejected // отклонена = 2
    }

    [Table("articles")]
    public class Article
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; } // заголовок статьи
        [Column("content")]
        public string Content { get; set; }
        [Column("image_url")]
        public string? ImageUrl { get; set; }
        [Column("crated_at")]
        public DateTime CreateAt { get; set; }
        //[Column("is_approved")]
        //public bool IsApproved { get; set; } = false; // поле для публикации статьи
        [Column("author_email")]
        public string AuthorEmail { get; set; }
        [Column("status")]
        public ArticleStatus Status { get; set; }

    }
}
