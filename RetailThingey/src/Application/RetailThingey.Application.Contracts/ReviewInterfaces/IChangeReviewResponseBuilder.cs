using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Contracts.Review;

public interface IChangeReviewResponseBuilder
{
    IChangeReviewResponseBuilder SetMessage(string message);
    ChangeReviewResponse Build();
}