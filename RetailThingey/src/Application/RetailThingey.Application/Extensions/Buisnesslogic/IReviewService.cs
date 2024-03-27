using RetailThingey.Application.Models.Review;

namespace RetailThingey.Application.Extensions.Buisnesslogic;

public interface IReviewService
{
    void AddReview(ReviewModels reviewModels);
    void DeleteReview(int reviewId);
}

public class ReviewService : IReviewService
{
    private readonly IReviewRepository _reviewRepository;

    public ReviewService(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }

    public void AddReview(ReviewModels reviewModels)
    {
        _reviewRepository.Add(reviewModels);
    }

    public void DeleteReview(int reviewId)
    {
        _reviewRepository.Delete(reviewId);
    }
}