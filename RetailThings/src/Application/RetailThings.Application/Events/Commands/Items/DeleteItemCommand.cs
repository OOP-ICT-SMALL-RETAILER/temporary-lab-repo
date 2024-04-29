using MediatR;

namespace RetailThings.Application.Events.Commands.Items;

public class DeleteItemCommand : IRequest
{
    public required int ItemId { get; set; }
}
