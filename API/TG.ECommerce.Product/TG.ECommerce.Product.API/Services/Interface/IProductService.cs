using System.Collections.Generic;
using System.Threading.Tasks;
using TG.ECommerce.Product.API.Models.Entities;
using TG.ECommerce.Shared.Responses;

namespace TG.ECommerce.Product.API.Services.Interface
{
    public interface IProductService
    {
        Task<Response<List<Models.Entities.Product>>> GetAllProduct();
        Task<Response<List<Models.Entities.Product>>> GetProductsByCategoryId(string categoryId);
    }
}
