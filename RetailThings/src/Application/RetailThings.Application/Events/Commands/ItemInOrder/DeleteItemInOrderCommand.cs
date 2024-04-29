using MediatR;

namespace RetailThings.Application.Events.Commands.ItemInOrder;

public class DeleteItemInOrderCommand : IRequest
{
    public required int ItemInOrderId { get; set; }
}
