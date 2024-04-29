using RetailThings.Application.Models.ItemInOrder;

namespace RetailThings.Application.Models.Order;

public record GetOrderModel
{
    public required int OrderId { get; set; }
    public required Entities.User User { get; set; }
    public required Entities.PickUpPoint PickUpPoint { get; set; }
    public required string Status { get; set; }
    public IReadOnlyCollection<GetItemInOrderModel>? ItemInOrders { get; init; }
}
