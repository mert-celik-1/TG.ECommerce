using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TG.ECommerce.Shared.Responses;
using TG.ECommerce.Web.Models;
using TG.ECommerce.Web.Services.Interface;

namespace TG.ECommerce.Web.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Response<List<CategoryViewModel>>> GetAllCategories()
        {
            List<CategoryViewModel> categoryList = new List<CategoryViewModel>();

            // get data from service with gateway
            var response = await _httpClient.GetAsync("services/product/categories/get");

            if (response.IsSuccessStatusCode)
            {
                // data read and deserialize to our entity class
                var catResponse = response.Content.ReadAsStringAsync().Result;
                categoryList = JsonConvert.DeserializeObject<List<CategoryViewModel>>(catResponse);
            }

            return new Response<List<CategoryViewModel>>(ResultStatus.Success, categoryList);
        }
    }
}
