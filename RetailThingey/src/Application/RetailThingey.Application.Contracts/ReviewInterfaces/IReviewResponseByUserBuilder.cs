using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Contracts.Review;

public interface ReviewResponseByUserBuilder
{
    ReviewResponseByUserBuilder setReviews(List<Models.Review.Review> reviews);
    ReviewResponseByUser build();
}