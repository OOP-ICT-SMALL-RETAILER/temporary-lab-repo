using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.PaidOrder;

namespace RetailThings.Application.Events.Handlers.PaidOrder;

public class CreatePaidOrderCommandHandler : IRequestHandler<CreatePaidOrderCommand>
{
    private readonly IPaidOrderService _orderService;

    public CreatePaidOrderCommandHandler(IPaidOrderService orderService)
    {
        _orderService = orderService;
    }

    public async Task Handle(CreatePaidOrderCommand request, CancellationToken cancellationToken)
    {
        await _orderService.CreatePaidOrder(request.CreatePaidOrderModel);
    }
}
