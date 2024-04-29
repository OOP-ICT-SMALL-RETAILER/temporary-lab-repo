using MediatR;
using RetailThings.Application.Models.ItemInOrder;

namespace RetailThings.Application.Events.Commands.ItemInOrder;

public class UpdateItemInOrderCommand : IRequest
{
    public required CreateItemInOrderModel CreateItemInOrderModel { get; set; }
}
