using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp1.Models
{
    [Table("product")]
    public class Product // = курсы по программированию
    {
        [Key]
        [Column("id")]
        public int Id { get; set; } // id
        [Column("name")]
        public string Title {  get; set; } // name
        [Column("description")]
        public string Description { get; set; } // description
        [Column("image_url")]
        public string ImageUrl { get; set; } // image_url
        [Column("price")]
        public int Price { get; set; } // price
    }

    public class ProductCardVm // для карточки продукта
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Title { get; set; } // name
        [Column("image_url")]
        public string ImageUrl { get; set; }
    }

    public class ProductDetailsVm  // для страницы продукта
    {
        [Column("name")]
        public string Title { get; set; } // name
        [Column("description")]
        public string Description { get; set; } // description
        [Column("image_url")]
        public string ImageUrl { get; set; } // image_url
        [Column("price")]
        public int Price { get; set; } // price
    }
}
