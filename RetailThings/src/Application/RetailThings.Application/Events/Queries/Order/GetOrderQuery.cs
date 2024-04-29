using MediatR;
using RetailThings.Application.Models.Order;

namespace RetailThings.Application.Events.Queries.Order;

public class GetOrderQuery : IRequest<GetOrderModel?>
{
    public required int OrderId { get; set; }
}
