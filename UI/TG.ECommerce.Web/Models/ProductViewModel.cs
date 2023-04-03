using System;

namespace TG.ECommerce.Web.Models
{
    public class ProductViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CategoryId { get; set; }

        public CategoryViewModel Category { get; set; }
    }
}
