using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TG.ECommerce.Product.API.Infrastructure;
using TG.ECommerce.Product.API.Services.Interface;
using TG.ECommerce.Shared.Responses;

namespace TG.ECommerce.Product.API.Services
{
    public class ProductService : IProductService
    {
        ECommerceDbContext _context;

        public ProductService(ECommerceDbContext context)
        {
            _context = context;
        }


        public async Task<Response<List<Models.Entities.Product>>> GetAllProduct()
        {
            var products = await _context.Products.ToListAsync();

            if (products ==null)
            {
                return new Response<List<Models.Entities.Product>>(ResultStatus.Error, "Products Not Found");
            }

            return new Response<List<Models.Entities.Product>>(ResultStatus.Success,products);
        }

        public async Task<Response<List<Models.Entities.Product>>> GetProductsByCategoryId(string categoryId)
        {
            var products = await _context.Products.Where(x=>x.CategoryId==categoryId).ToListAsync();

            if (products == null)
            {
                return new Response<List<Models.Entities.Product>>(ResultStatus.Error, "Products Not Found");
            }

            return new Response<List<Models.Entities.Product>>(ResultStatus.Success, products);
        }
    }
}
