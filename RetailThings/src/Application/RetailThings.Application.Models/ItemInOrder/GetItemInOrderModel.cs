namespace RetailThings.Application.Models.ItemInOrder;

public record GetItemInOrderModel
{
    public required Entities.Item Item { get; set; }
    public required int OrderId { get; set; }
    public required int Count { get; set; }
    public required double Price { get; set; }
}
