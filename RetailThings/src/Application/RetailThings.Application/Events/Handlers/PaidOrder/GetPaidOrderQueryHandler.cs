using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Queries.PaidOrder;
using RetailThings.Application.Models.PaidOrder;

namespace RetailThings.Application.Events.Handlers.PaidOrder;

public class GetPaidOrderQueryHandler : IRequestHandler<GetPaidOrderQuery, GetPaidOrderModel?>
{
    private readonly IPaidOrderService _orderService;

    public GetPaidOrderQueryHandler(IPaidOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task<GetPaidOrderModel?> Handle(GetPaidOrderQuery request, CancellationToken cancellationToken)
    {
        return await _orderService.GetPaidOrderById(request.PaidOrderId);
    }
}
