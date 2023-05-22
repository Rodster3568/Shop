using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Заполните название.")]
        [DisplayName("Название")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Заполните краткое описание.")]
        [DisplayName("Краткое описание")]
        public string ShortDesc { get; set; }
        [Required(ErrorMessage = "Заполните описание.")]
        [DisplayName("Описание")]
        public string Description { get; set; }
        [Range(1, 100000, ErrorMessage = "Минимальная стоимость:1")]
        [DisplayName("Стоимость")]
        public double Price { get; set; }
        [DisplayName("Изображение")]
        public string? Image { get; set; }
        [Required(ErrorMessage = "Выберите категорию.")]
        [Display(Name = "Category Type")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
    }
}
