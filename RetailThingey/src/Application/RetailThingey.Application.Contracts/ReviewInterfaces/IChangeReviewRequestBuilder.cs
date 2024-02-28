using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Contracts.Review;

public interface IChangeReviewRequestBuilder
{
    IChangeReviewRequestBuilder SetUserCookie(string userCookie);
    IChangeReviewRequestBuilder SetReviewId(string reviewId);
    IChangeReviewRequestBuilder SetRating(int? rating);
    IChangeReviewRequestBuilder SetComment(string comment);
    ChangeReviewRequest Build();
}