using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.Shop;

namespace RetailThings.Application.Events.Handlers.Shop;

public class DeleteShopCommandHandler : IRequestHandler<DeleteShopCommand>
{
    private readonly IShopService _shopService;

    public DeleteShopCommandHandler(IShopService shopService)
    {
        _shopService = shopService;
    }

    public async Task Handle(DeleteShopCommand request, CancellationToken cancellationToken)
    {
        await _shopService.DeleteShop(request.ShopId);
    }
}
