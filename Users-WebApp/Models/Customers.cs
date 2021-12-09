using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Users_WebApp.Models
{
    public class Customers
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public bool CanOrder { get; set; }

        public bool FlaggedForDelete { get; set; }
    }
}
