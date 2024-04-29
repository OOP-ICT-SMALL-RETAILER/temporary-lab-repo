namespace RetailThings.Application.Models.ItemInOrder;

public record CreateItemInOrderModel
{
    public required int OrderId { get; set; }
    public required int ItemId { get; set; }
    public required int Count { get; set; }
    public required double Price { get; set; }
}
