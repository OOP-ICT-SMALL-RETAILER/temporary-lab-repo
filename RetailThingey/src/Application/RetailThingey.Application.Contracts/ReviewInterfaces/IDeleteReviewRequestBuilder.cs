using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Contracts.Review;

public interface IDeleteReviewRequestBuilder
{
    IDeleteReviewRequestBuilder SetUserCookie(string userCookie);
    IDeleteReviewRequestBuilder SetReviewId(string reviewId);
    DeleteReviewRequest Build();
}