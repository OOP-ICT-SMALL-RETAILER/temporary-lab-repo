using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Contracts.Review;

public interface IReviewResponseByUserBuilder
{
    IReviewResponseByUserBuilder SetReviews(IList<ReviewModels> reviews);
    ReviewResponseByUser Build();
}