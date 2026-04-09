using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp1.Models
{
    public class Product // = курсы по программированию
    {
        [Key]
        [Column("id")]
        public int Id { get; set; } // id
        [Column("name")]
        public string Name {  get; set; } // name
        [Column("description")]
        public string Description { get; set; } // description
        [Column("image_url")]
        public string ImageUrl { get; set; } // image_url
        [Column("price")]
        public int Price { get; set; } // price

    }
}
