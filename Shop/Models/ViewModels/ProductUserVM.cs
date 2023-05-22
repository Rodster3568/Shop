namespace Shop.Models.ViewModels
{
    public class ProductUserVM
    {
        public ApplicationUser ApplicationUser { get; set; }
        public IEnumerable<Product> ProductList { get; set; }
    }
}
