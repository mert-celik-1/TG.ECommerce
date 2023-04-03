using System.Collections.Generic;

namespace TG.ECommerce.Product.API.Models.Entities
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
