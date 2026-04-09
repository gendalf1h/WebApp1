using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp1.Models
{
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
        public string ImageUrl { get; set; }
        [Column("crated_at")]
        public DateTime CreateAt { get; set; }

    }
}
