using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Users_WebApp.Models.DomainModels
{
    public class PostOrderDomainModel
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public DateTime OrderDate { get; set; }

        public int OrderProductQuantity { get; set; }

        public int OrderTotalPrice { get; set; }
    }
}
