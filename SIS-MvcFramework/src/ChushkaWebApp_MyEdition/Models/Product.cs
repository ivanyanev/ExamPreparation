using System.ComponentModel.DataAnnotations;

namespace ChushkaWebApp_MyEdition.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public ProductType Type { get; set; }

        [Range(0, 1)]
        public int IsDeleted { get; set; } = 0;
    }
}
