using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Users_WebApp.Models.DomainModels
{
    public class GetProductsDomainModel
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int productQuantity { get; set; }
        public double productPrice { get; set; }
        public string productDescription { get; set; }
    }
}
