using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.Shop;

namespace RetailThings.Application.Events.Handlers.Shop;

public class UpdateShopCommandHandler : IRequestHandler<UpdateShopCommand>
{
    private readonly IShopService _shopService;

    public UpdateShopCommandHandler(IShopService shopService)
    {
        _shopService = shopService;
    }

    public async Task Handle(UpdateShopCommand request, CancellationToken cancellationToken)
    {
        await _shopService.UpdateShop(request.Shop);
    }
}
