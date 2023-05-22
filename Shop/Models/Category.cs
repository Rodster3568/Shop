using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Название")]
        [Required(ErrorMessage = "Название не может быть пустым.")]

        public string Name { get; set; }
        [DisplayName("Порядок отображения")]
        [Required(ErrorMessage = "Порядок отображения не может быть пустым.")]
        [Range(1, 100000, ErrorMessage = "Порядок отображения должен быть больше, чем 0.")]
        public int? DisplayOrder { get; set; }
    }
}
