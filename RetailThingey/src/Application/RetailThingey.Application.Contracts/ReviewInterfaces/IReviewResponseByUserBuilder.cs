using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Contracts.Review;

public interface ReviewResponseByUserBuilder
{
    ReviewResponseByUserBuilder setReviews(List<Review> reviews);
    ReviewResponseByUser build();
}