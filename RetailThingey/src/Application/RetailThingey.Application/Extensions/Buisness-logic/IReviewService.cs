using RetailThingey.Application.Models.Review;

public interface IReviewService
{
    void AddReview(Review review);
    void DeleteReview(int reviewId);
}

public class ReviewService : IReviewService
{
    private readonly IReviewRepository _reviewRepository;

    public ReviewService(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }

    public void AddReview(Review review)
    {
        _reviewRepository.Add(review);
    }

    public void DeleteReview(int reviewId)
    {
        _reviewRepository.Delete(reviewId);
    }
}