namespace RetailThings.Application.Models.Order;

public record CreateOrderModel
{
    public required int UserId { get; set; }
    public required int PickUpPointId { get; set; }
    public required string Status { get; set; }
}
