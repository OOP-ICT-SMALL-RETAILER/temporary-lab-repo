using MediatR;
using RetailThings.Application.Models.Item;

namespace RetailThings.Application.Events.Commands.Items;

public class UpdateItemCommand : IRequest
{
    public required CreateItemModel CreateItemModel { get; set; }
}
