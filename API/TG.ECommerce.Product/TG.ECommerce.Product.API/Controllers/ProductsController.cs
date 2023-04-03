using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TG.ECommerce.Product.API.Services.Interface;

namespace TG.ECommerce.Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAllProduct();

            return Ok(products.Data);
        }

        [HttpGet]
        [Route("getByCategoryId")]
        public async Task<IActionResult> GetByCategoryId(string id)
        {
            var products = await _productService.GetProductsByCategoryId(id);

            return Ok(products.Data);
        }
    }
}
