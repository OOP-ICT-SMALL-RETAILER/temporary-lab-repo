using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.ItemInOrder;

namespace RetailThings.Application.Events.Handlers.ItemInOrder;

public class UpdateItemInOrderCommandHandler : IRequestHandler<UpdateItemInOrderCommand>
{
    private readonly IItemInOrderService _itemInOrderService;

    public UpdateItemInOrderCommandHandler(IItemInOrderService itemInOrderService)
    {
        _itemInOrderService = itemInOrderService;
    }

    public async Task Handle(UpdateItemInOrderCommand request, CancellationToken cancellationToken)
    {
        await _itemInOrderService.UpdateItemInOrder(request.CreateItemInOrderModel);
    }
}
