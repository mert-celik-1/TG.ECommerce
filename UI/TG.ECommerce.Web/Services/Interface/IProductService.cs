using System.Collections.Generic;
using System.Threading.Tasks;
using TG.ECommerce.Shared.Responses;
using TG.ECommerce.Web.Models;

namespace TG.ECommerce.Web.Services.Interface
{
    public interface IProductService
    {
        Task<Response<List<ProductViewModel>>> GetAllProduct();
        Task<Response<List<ProductViewModel>>> GetByCategoryId(string id);
    }
}
