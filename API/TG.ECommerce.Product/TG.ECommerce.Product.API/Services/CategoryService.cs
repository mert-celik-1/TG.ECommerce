using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TG.ECommerce.Product.API.Infrastructure;
using TG.ECommerce.Product.API.Models.Entities;
using TG.ECommerce.Product.API.Services.Interface;
using TG.ECommerce.Shared.Responses;

namespace TG.ECommerce.Product.API.Services
{
    public class CategoryService:ICategoryService
    {
        ECommerceDbContext _context;

        public CategoryService(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task<Response<List<Category>>> GetAllCategories()
        {
            var categories = await _context.Categories.ToListAsync();

            if (categories == null)
            {
                return new Response<List<Category>>(ResultStatus.Error, "Categories Not Found");
            }

            return new Response<List<Category>>(ResultStatus.Success, categories);
        }
    }
}
