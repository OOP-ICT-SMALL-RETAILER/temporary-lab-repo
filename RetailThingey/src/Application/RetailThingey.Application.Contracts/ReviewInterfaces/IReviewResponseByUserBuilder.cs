using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Contracts.Review;

public interface IReviewResponseByUserBuilder
{
    ReviewResponseByUserBuilder setReviews(List<Models.Review.ReviewModels> reviews);
    ReviewResponseByUser build();
}