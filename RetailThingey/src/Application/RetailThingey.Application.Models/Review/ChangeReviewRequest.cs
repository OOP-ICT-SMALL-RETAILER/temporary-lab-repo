namespace RetailThingey.Application.Models.Review;

public class ChangeReviewRequest(string userCookie, string reviewId, int? rating, string comment)
{
    public string UserCookie { get; set; } = userCookie;
    public string ReviewId { get; set; } = reviewId;
    public int? Rating { get; set; } = rating;
    public string Comment { get; set; } = comment;
}