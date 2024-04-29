using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.Shop;

namespace RetailThings.Application.Events.Handlers.Shop;

public class CreateShopCommandHandler : IRequestHandler<CreateShopCommand>
{
    private readonly IShopService _shopService;

    public CreateShopCommandHandler(IShopService shopService)
    {
        _shopService = shopService;
    }

    public async Task Handle(CreateShopCommand request, CancellationToken cancellationToken)
    {
        await _shopService.CreateShop(request.ShopModel);
    }
}
