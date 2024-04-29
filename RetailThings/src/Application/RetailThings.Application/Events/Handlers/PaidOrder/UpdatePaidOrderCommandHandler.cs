using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.PaidOrder;

namespace RetailThings.Application.Events.Handlers.PaidOrder;

public class UpdatePaidOrderCommandHandler : IRequestHandler<UpdatePaidOrderCommand>
{
    private readonly IPaidOrderService _orderService;

    public UpdatePaidOrderCommandHandler(IPaidOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task Handle(UpdatePaidOrderCommand request, CancellationToken cancellationToken)
    {
        await _orderService.UpdatePaidOrder(request.CreatePaidOrderModel);
    }
}
