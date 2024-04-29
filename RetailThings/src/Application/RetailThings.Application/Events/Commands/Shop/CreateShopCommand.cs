using MediatR;
using RetailThings.Application.Models.Shop;

namespace RetailThings.Application.Events.Commands.Shop;

public class CreateShopCommand : IRequest
{
    public required ShopModel ShopModel { get; set; }
}
