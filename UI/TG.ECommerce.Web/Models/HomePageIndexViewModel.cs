using System.Collections.Generic;

namespace TG.ECommerce.Web.Models
{
    public class HomePageIndexViewModel
    {
        public List<ProductViewModel> Products { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
    }
}
