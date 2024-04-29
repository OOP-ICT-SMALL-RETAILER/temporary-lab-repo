using MediatR;

namespace RetailThings.Application.Events.Commands.PickUp;

public class DeletePickUpCommand : IRequest
{
    public required int PickUpPointId { get; set; }
}
