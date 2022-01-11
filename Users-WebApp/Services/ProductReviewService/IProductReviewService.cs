using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users_WebApp.Models.DomainModels;

namespace Users_WebApp.Services.ProductReviewService
{
    public interface IProductReviewService
    {
        public Task<IEnumerable<GetProductReviewsModel>> GetAllProductReviews();

        public Task<PostProductReview> PostProductReview(PostProductReview postProductReview);
    }
}
