using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Users_WebApp.Models.DomainModels;

namespace Users_WebApp.Services.OrdersService
{
    public class OrdersService 
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _client;
        public OrdersService(IConfiguration config, HttpClient client)
        {
            _config = config;

            client.BaseAddress = _config.GetValue<Uri>("ORDERS_URL");
            client.Timeout = TimeSpan.FromSeconds(5);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            _client = client;
        }

        public async Task<IEnumerable<GetOrdersDomainModel>> GetAllOrders()
        {
            var response = await _client.GetAsync("");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();
            var Orders = await response.Content.ReadAsAsync<IEnumerable<GetOrdersDomainModel>>();
            return Orders;
        }

        
    }
}
