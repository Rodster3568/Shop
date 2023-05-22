using Microsoft.AspNetCore.Mvc.Rendering;

namespace Shop.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product = new Product();
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
    }
}
