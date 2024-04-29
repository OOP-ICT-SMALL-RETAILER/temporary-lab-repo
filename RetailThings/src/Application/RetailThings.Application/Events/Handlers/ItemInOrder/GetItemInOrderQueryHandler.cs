using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Queries.ItemInOrder;
using RetailThings.Application.Models.ItemInOrder;

namespace RetailThings.Application.Events.Handlers.ItemInOrder;

public class GetItemInOrderQueryHandler : IRequestHandler<GetItemInOrderQuery, GetItemInOrderModel?>
{
    private readonly IItemInOrderService _itemInOrderService;

    public GetItemInOrderQueryHandler(IItemInOrderService itemInOrderService)
    {
        _itemInOrderService = itemInOrderService;
    }
    
    public async Task<GetItemInOrderModel?> Handle(GetItemInOrderQuery request, CancellationToken cancellationToken)
    {
        return await _itemInOrderService.GetItemInOrder(request.ItemInOrderId);
    }
}
