using System.Collections.Generic;
using System.Threading.Tasks;
using TG.ECommerce.Product.API.Models.Entities;
using TG.ECommerce.Shared.Responses;

namespace TG.ECommerce.Product.API.Services.Interface
{
    public interface ICategoryService
    {
        Task<Response<List<Category>>> GetAllCategories();

    }
}
