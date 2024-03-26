namespace RetailThingey.Application.Models.Review;

public class ReviewModels(string userCookie, string reviewId, string productId, string comment)
{
    public string UserCookie { get; set; } = userCookie;

    public string ReviewId { get; set; } = reviewId;
    
    public string ProductId { get; set; } = productId;
    
    public int Rating { get; set; }
    
    public string Comment { get; set; } = comment;
}