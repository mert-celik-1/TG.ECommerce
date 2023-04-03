using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TG.ECommerce.Product.API.Services.Interface;

namespace TG.ECommerce.Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetAllCategories();

            return Ok(categories.Data);
        }
    }
}
