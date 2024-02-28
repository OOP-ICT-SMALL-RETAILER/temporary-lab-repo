namespace RetailThingey.Application.Contracts.Review;

public interface IReviewBuilder
{
    IReviewBuilder SetUserCookie(string userCookie);
    IReviewBuilder SetReviewId(string reviewId);
    IReviewBuilder SetProductID(string productId);
    IReviewBuilder SetRating(int rating);
    IReviewBuilder SetComment(string comment);
    Models.Review.Review Build();
}