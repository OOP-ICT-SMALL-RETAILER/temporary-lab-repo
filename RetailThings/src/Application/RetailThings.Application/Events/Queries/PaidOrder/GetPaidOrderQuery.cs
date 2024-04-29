using MediatR;
using RetailThings.Application.Models.PaidOrder;

namespace RetailThings.Application.Events.Queries.PaidOrder;

public class GetPaidOrderQuery : IRequest<GetPaidOrderModel?>
{
    public required int PaidOrderId { get; set; }
}
