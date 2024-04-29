using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Queries.Items;
using RetailThings.Application.Models.Item;

namespace RetailThings.Application.Events.Handlers.Items;

public class GetItemQueryHandler : IRequestHandler<GetItemQuery, GetItemModel?>
{
    private readonly IItemService _itemService;

    public GetItemQueryHandler(IItemService itemService)
    {
        _itemService = itemService;
    }
    
    public async Task<GetItemModel?> Handle(GetItemQuery request, CancellationToken cancellationToken)
    {
        return await _itemService.GetItemById(request.ItemId);
    }
}
