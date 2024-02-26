namespace RetailThingey.Application.Models.Review;

public class ChangeReviewRequest
{
    public string UserCookie { get; set; }
    public string ReviewId { get; set; }
    public int? Rating { get; set; }
    public string Comment { get; set; }
}