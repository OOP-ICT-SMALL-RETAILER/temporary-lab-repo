using Microsoft.AspNetCore.Mvc;
using RetailThingey.Application.Models.Review;
using System.Collections.Generic;

namespace IReview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost]
        public ActionResult Add(ReviewModels reviewModels)
        {
            _reviewService.AddReview(reviewModels);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _reviewService.DeleteReview(id);
            return Ok();
        }
    }
}