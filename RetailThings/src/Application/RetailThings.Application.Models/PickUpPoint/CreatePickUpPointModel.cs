namespace RetailThings.Application.Models.PickUpPoint;

public record CreatePickUpPointModel
{
    public required string Title { get; set; }
    public required string Address { get; set; }
}
