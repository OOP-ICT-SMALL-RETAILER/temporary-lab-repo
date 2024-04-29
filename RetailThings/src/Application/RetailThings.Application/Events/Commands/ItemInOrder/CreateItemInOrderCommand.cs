using MediatR;
using RetailThings.Application.Models.ItemInOrder;

namespace RetailThings.Application.Events.Commands.ItemInOrder;

public class CreateItemInOrderCommand : IRequest
{
    public required CreateItemInOrderModel CreateItemInOrderModel { get; set; }
}
