using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.ItemInOrder;

namespace RetailThings.Application.Events.Handlers.ItemInOrder;

public class CreateItemInOrderCommandHandler : IRequestHandler<CreateItemInOrderCommand>
{
    private readonly IItemInOrderService _itemInOrderService;

    public CreateItemInOrderCommandHandler(IItemInOrderService itemInOrderService)
    {
        _itemInOrderService = itemInOrderService;
    }

    public async Task Handle(CreateItemInOrderCommand request, CancellationToken cancellationToken)
    {
        await _itemInOrderService.CreateItemInOrder(request.CreateItemInOrderModel);
    }
}
