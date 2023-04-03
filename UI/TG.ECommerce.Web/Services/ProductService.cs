using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime;
using System.Threading.Tasks;
using TG.ECommerce.Shared.Responses;
using TG.ECommerce.Web.Models;
using TG.ECommerce.Web.Services.Interface;

namespace TG.ECommerce.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Response<List<ProductViewModel>>> GetAllProduct()
        {

            List<ProductViewModel> productList = new List<ProductViewModel>();

            // get data from service with gateway
            var response = await _httpClient.GetAsync("services/product/products/get");

            if (response.IsSuccessStatusCode)
            {
                // data read and deserialize to our entity class
                var productResponse = response.Content.ReadAsStringAsync().Result;
                productList = JsonConvert.DeserializeObject<List<ProductViewModel>>(productResponse);
            }

            return new Response<List<ProductViewModel>>(ResultStatus.Success,productList);

        }

        public async Task<Response<List<ProductViewModel>>> GetByCategoryId(string id)
        {

            List<ProductViewModel> productList = new List<ProductViewModel>();

            // get data from service with gateway
            var response = await _httpClient.GetAsync("services/product/products/getByCategoryId?id="+id);

            if (response.IsSuccessStatusCode)
            {
                // data read and deserialize to our entity class
                var productResponse = response.Content.ReadAsStringAsync().Result;
                productList = JsonConvert.DeserializeObject<List<ProductViewModel>>(productResponse);
            }

            return new Response<List<ProductViewModel>>(ResultStatus.Success, productList);

        }
    }
}
