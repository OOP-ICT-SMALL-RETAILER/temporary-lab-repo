using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.Items;

namespace RetailThings.Application.Events.Handlers.Items;

public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand>
{
    private readonly IItemService _itemService;

    public CreateItemCommandHandler(IItemService itemService)
    {
        _itemService = itemService;
    }

    public async Task Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        await _itemService.CreateItem(request.CreateItemModel);
    }
}
