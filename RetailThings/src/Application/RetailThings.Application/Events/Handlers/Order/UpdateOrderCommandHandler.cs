using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.Order;

namespace RetailThings.Application.Events.Handlers.Order;

public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
{
    private readonly IOrderService _orderService;

    public UpdateOrderCommandHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        await _orderService.UpdateOrder(request.CreateOrderModel);
    }
}
