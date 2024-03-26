namespace RetailThingey.Application.Models.Review;

#pragma warning disable SA1516 // ElementsMustBeSeparatedByBlankLine
#pragma warning restore SA1516 // ElementsMustBeSeparatedByBlankLine

public class ChangeReviewRequest(string userCookie, string reviewId, int? rating, string comment)
{
    public string UserCookie { get; set; } = userCookie;
    public string ReviewId { get; set; } = reviewId;
    public int? Rating { get; set; } = rating;
    public string Comment { get; set; } = comment;
}