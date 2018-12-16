using ChushkaWebApp_MyEdition.Models;

namespace ChushkaWebApp_MyEdition.ViewModels.Products
{
    public class ProductDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ProductType Type { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
