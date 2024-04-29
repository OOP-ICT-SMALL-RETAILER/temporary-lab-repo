using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.ItemInOrder;

namespace RetailThings.Application.Events.Handlers.ItemInOrder;

public class DeleteItemInOrderCommandHandler : IRequestHandler<DeleteItemInOrderCommand>
{
    private readonly IItemInOrderService _itemInOrderService;

    public DeleteItemInOrderCommandHandler(IItemInOrderService itemInOrderService)
    {
        _itemInOrderService = itemInOrderService;
    }
    
    public async Task Handle(DeleteItemInOrderCommand request, CancellationToken cancellationToken)
    {
        await _itemInOrderService.DeleteItemInOrder(request.ItemInOrderId);
    }
}
