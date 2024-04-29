using MediatR;

namespace RetailThings.Application.Events.Commands.Shop;

public class DeleteShopCommand : IRequest
{
    public required int ShopId { get; set; }
}
