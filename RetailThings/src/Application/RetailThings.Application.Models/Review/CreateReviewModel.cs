namespace RetailThings.Application.Models.Review;

public record CreateReviewModel
{
    public required int UserId { get; set; }
    public required int ItemId { get; set; }
    public required double Rating { get; set; }
    public required string Description { get; set; }
}
