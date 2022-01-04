using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Users_WebApp.Models
{
    public class ProductReview
    {
        public int Id { get; set; }

        public string ProductReviewHeader { get; set; }

        public string ProductReviewContent { get; set; }

        public DateTime ProductReviewDateTime { get; set; } 
    }
}
