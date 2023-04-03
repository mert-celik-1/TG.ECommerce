using System.Text.Json.Serialization;
using System;

namespace TG.ECommerce.Product.API.Models.Entities
{
    public class Product
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
