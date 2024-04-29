using MediatR;
using RetailThings.Application.Models.PickUpPoint;

namespace RetailThings.Application.Events.Commands.PickUp;

public class UpdatePickUpCommand : IRequest
{
    public required CreatePickUpPointModel PickUpPoint { get; set; }
}
