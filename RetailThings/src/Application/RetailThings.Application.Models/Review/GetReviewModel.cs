namespace RetailThings.Application.Models.Review;

public record GetReviewModel
{
    public required int ReviewId { get; set; }
    public required Entities.User User { get; set; }
    public required Entities.Item Item { get; set; }
    public required double Rating { get; set; }
    public required string Description { get; set; }
}
