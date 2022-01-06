using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users_WebApp.Models.DomainModels;

namespace Users_WebApp.Services.CustomersService
{
    public interface ICustomersService
    {
        public Task<IEnumerable<GetCustomersDomainModel>> GetAllCustomers();
    }
}
