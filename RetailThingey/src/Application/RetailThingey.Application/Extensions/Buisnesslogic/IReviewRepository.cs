using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Extensions.Buisnesslogic;

public interface IReviewRepository
{
    void Add(ReviewModels reviewModels);
    void Delete(int reviewId);
}