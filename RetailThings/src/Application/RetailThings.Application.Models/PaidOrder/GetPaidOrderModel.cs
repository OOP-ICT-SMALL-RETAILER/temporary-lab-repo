namespace RetailThings.Application.Models.PaidOrder;

public record GetPaidOrderModel
{
    public required int PaidOrderId { get; set; }
    public required int OrderId { get; set; }
    public required DateTimeOffset DatePaid { get; set; }
}
