using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Users_WebApp.Models
{
    public class Orders
    {
        public int OrdersID { get; set; }

        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public DateTime OrderDate { get; set; }

        public int OrderProductQuantity { get; set; }

        public int OrderTotalPrice { get; set; }
    }
}
