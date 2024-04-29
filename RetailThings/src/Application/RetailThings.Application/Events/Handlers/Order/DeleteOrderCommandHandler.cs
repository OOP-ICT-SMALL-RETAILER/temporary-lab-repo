using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.Order;

namespace RetailThings.Application.Events.Handlers.Order;

public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand>
{
    private readonly IOrderService _orderService;

    public DeleteOrderCommandHandler(IOrderService orderService)
    {
        _orderService = orderService;
    }
    
    public async Task Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
    {
        await _orderService.DeleteOrder(request.OrderId);
    }
}
