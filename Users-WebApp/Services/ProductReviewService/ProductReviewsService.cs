using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Users_WebApp.Models.DomainModels;
using System.Net.Http;

namespace Users_WebApp.Services.ProductReviewService
{
    public class ProductReviewsService : IProductReviewService
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _client;
        public ProductReviewsService(IConfiguration config, HttpClient client)
        {
            _config = config;

            client.BaseAddress = _config.GetValue<Uri>("PRODUCT_REVIEWS_URL");
            client.Timeout = TimeSpan.FromSeconds(5);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            _client = client;
        }

        public async Task<IEnumerable<GetProductReviewsModel>> GetAllProductReviews()
        {
            var response = await _client.GetAsync("");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();
            var ProductReviews = await response.Content.ReadAsAsync<IEnumerable<GetProductReviewsModel>>();
            return ProductReviews;
        }
    }
}
