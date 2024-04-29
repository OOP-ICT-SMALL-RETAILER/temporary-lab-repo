using MediatR;

namespace RetailThings.Application.Events.Commands.Shop;

public class UpdateShopCommand : IRequest
{
    public required Models.Entities.Shop Shop { get; set; }
}
