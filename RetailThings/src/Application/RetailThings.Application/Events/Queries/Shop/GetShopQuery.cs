using MediatR;

namespace RetailThings.Application.Events.Queries.Shop;

public class GetShopQuery : IRequest<Models.Entities.Shop?>
{
    public required int ShopId { get; set; }
}
