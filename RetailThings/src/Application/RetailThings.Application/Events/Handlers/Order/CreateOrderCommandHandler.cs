using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.Order;

namespace RetailThings.Application.Events.Handlers.Order;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
{
    private readonly IOrderService _orderService;

    public CreateOrderCommandHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        await _orderService.CreateOrder(request.CreateOrderModel);
    }
}
