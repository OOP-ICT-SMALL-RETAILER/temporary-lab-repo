using MediatR;

namespace RetailThings.Application.Events.Commands.Order;

public class DeleteOrderCommand : IRequest
{
    public required int OrderId { get; set; }
}
