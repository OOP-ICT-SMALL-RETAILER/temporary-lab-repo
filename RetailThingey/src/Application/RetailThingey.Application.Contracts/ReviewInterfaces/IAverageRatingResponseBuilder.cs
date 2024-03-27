using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Contracts.Review;

public interface IAverageRatingResponseBuilder
{
    IAverageRatingResponseBuilder SetAverageRating(double averageRating);
    AverageRatingResponse Build();
}