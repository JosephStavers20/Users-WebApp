using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Users_WebApp.Models.DomainModels
{
    public class PostCustomerAccountDeletionRequestsDomainModel
    {
        public int CustomerID { get; set; }

        public string DeletionReason { get; set; }
    }
}
