using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Contracts.Review;

public interface IReviewResponseBuilder
{
    IReviewResponseBuilder SetMessage(string message);
    ReviewResponse Build();
}