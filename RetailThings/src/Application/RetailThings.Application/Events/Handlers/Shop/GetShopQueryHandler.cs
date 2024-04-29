using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Queries.Shop;

namespace RetailThings.Application.Events.Handlers.Shop;

public class GetShopQueryHandler : IRequestHandler<GetShopQuery, Models.Entities.Shop?>
{
    private readonly IShopService _shopService;

    public GetShopQueryHandler(IShopService shopService)
    {
        _shopService = shopService;
    }
    public async Task<Models.Entities.Shop?> Handle(GetShopQuery request, CancellationToken cancellationToken)
    {
        return await _shopService.GetShopById(request.ShopId);
    }
}
