using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.Items;

namespace RetailThings.Application.Events.Handlers.Items;

public class UpdateItemCommandHandler : IRequestHandler<UpdateItemCommand>
{
    private readonly IItemService _itemService;

    public UpdateItemCommandHandler(IItemService itemService)
    {
        _itemService = itemService;
    }

    public async Task Handle(UpdateItemCommand request, CancellationToken cancellationToken)
    {
        await _itemService.UpdateItem(request.CreateItemModel);
    }
}
