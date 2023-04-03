using System.Collections.Generic;
using System.Threading.Tasks;
using TG.ECommerce.Shared.Responses;
using TG.ECommerce.Web.Models;

namespace TG.ECommerce.Web.Services.Interface
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryViewModel>>> GetAllCategories();

    }
}
