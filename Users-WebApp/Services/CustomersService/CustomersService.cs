using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Users_WebApp.Models.DomainModels;

namespace Users_WebApp.Services.CustomersService
{
    public class CustomersService : ICustomersService
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _client;
        public CustomersService(IConfiguration config, HttpClient client)
        {
            _config = config;

            client.BaseAddress = _config.GetValue<Uri>("CUSTOMERS_URL");
            client.Timeout = TimeSpan.FromSeconds(5);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            _client = client;
        }

        public async Task<IEnumerable<GetCustomersDomainModel>> GetAllCustomers()
        {
            var response = await _client.GetAsync("");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();
            var AllCustomers = await response.Content.ReadAsAsync<IEnumerable<GetCustomersDomainModel>>();
            return AllCustomers;
        }
    }
}
