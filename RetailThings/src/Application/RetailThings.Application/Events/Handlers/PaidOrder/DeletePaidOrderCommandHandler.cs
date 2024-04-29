using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.PaidOrder;

namespace RetailThings.Application.Events.Handlers.PaidOrder;

public class DeletePaidOrderCommandHandler : IRequestHandler<DeletePaidOrderCommand>
{
    private readonly IPaidOrderService _orderService;

    public DeletePaidOrderCommandHandler(IPaidOrderService orderService)
    {
        _orderService = orderService;
    }
    
    public async Task Handle(DeletePaidOrderCommand request, CancellationToken cancellationToken)
    {
        await _orderService.DeletePaidOrder(request.PaidOrderId);
    }
}
