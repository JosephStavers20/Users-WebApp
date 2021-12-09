using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Users_WebApp.Models
{
    public class CustomerAccountDeletionRequest
    {
        public int CustomerID { get; set; }

        public string DeletionReason { get; set; }

        public DateTime DateRequested { get; set; }
    }
}
