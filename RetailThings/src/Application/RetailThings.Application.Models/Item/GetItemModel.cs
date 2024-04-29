namespace RetailThings.Application.Models.Item;

public record GetItemModel
{
    public required int ItemId { get; set; }
    public required Entities.Shop Shop { get; set; }
    public required double FullPrice { get; set; }
    public required double CurrentPrice { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required double Rating { get; set; }
    public required int CountOfRatings { get; set; }
    public required string Category { get; set; }
    public required bool IsSale { get; set; }
}
