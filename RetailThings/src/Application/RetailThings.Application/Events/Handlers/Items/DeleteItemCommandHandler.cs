using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.Items;

namespace RetailThings.Application.Events.Handlers.Items;

public class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand>
{
    private readonly IItemService _itemService;

    public DeleteItemCommandHandler(IItemService itemService)
    {
        _itemService = itemService;
    }
    
    public async Task Handle(DeleteItemCommand request, CancellationToken cancellationToken)
    {
        await _itemService.DeleteItem(request.ItemId);
    }
}
