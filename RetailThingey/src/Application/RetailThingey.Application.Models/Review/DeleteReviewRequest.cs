namespace RetailThingey.Application.Models.Review;

public class DeleteReviewRequest(string userCookie, string reviewId)
{
    public string UserCookie { get; } = userCookie;

    public string ReviewId { get; set; } = reviewId;
}