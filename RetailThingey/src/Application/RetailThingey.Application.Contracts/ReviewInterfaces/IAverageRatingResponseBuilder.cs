using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Contracts.Review;

public interface AverageRatingResponseBuilder
{
    AverageRatingResponseBuilder setAverageRating(double averageRating);
    AverageRatingResponse build();
}