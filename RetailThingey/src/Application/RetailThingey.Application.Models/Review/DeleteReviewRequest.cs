namespace RetailThingey.Application.Models.Review;

public class DeleteReviewRequest
{
    public string UserCookie { get; }
    public string ReviewId { get; set; }
}