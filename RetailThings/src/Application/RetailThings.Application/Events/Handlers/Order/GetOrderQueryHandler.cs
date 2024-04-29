using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Queries.Order;
using RetailThings.Application.Models.Order;

namespace RetailThings.Application.Events.Handlers.Order;

public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, GetOrderModel?>
{
    private readonly IOrderService _orderService;

    public GetOrderQueryHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task<GetOrderModel?> Handle(GetOrderQuery request, CancellationToken cancellationToken)
    {
        return await _orderService.GetOrderById(request.OrderId);
    }
}
