using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users_WebApp.Models.DomainModels;

namespace Users_WebApp.Services.ProductsService
{
    public class FakeProductsService : IProductsService
    {
        private readonly GetProductsDomainModel[] _products =
        {
            new GetProductsDomainModel {productID = 1, productDescription = "This is an example Item", productName = "Example Item no1", productPrice = 36, productQuantity = 102},
            new GetProductsDomainModel {productID = 2, productDescription = "This is the second example Item", productName = "Example Item no2", productPrice = 63, productQuantity = 201}
        };

        public Task<IEnumerable<GetProductsDomainModel>> GetAllProducts()
        {
            var products = _products.AsEnumerable();
            
            return Task.FromResult(products);
        }
    }
}
