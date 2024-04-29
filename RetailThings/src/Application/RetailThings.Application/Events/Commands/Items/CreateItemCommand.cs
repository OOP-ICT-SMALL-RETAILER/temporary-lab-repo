using MediatR;
using RetailThings.Application.Models.Item;

namespace RetailThings.Application.Events.Commands.Items;

public class CreateItemCommand : IRequest
{
    public required CreateItemModel CreateItemModel { get; set; }
}
