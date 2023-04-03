using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TG.ECommerce.Web.Models;
using TG.ECommerce.Web.Services.Interface;

namespace TG.ECommerce.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMemoryCache _cacheService;
        public ProductsController(IProductService productService,ICategoryService categoryService, IMemoryCache cacheService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _cacheService = cacheService;
        }
        public async Task<IActionResult> Index()
        {
            var viewResult = new HomePageIndexViewModel();

            // control that take category data from cache
            if (!_cacheService.TryGetValue("CategoryCache",out List<CategoryViewModel> categories))
            {
                var categoryCache = await _categoryService.GetAllCategories();
              
                _cacheService.Set("CategoryCache", categoryCache.Data);

                viewResult.Categories = categoryCache.Data;
            }
            else
            {
                viewResult.Categories = categories;
            }

            return View(viewResult);
        }

        public async Task<IActionResult> GetProducts()
        {

            var productResult = await _productService.GetAllProduct();

            return Json(new { data = productResult.Data });
        }

        public async Task<IActionResult> GetProductsByCategory(string id)
        {

            var productResult = await _productService.GetByCategoryId(id);

            return Json(new { data = productResult.Data });
        }
    }
}
