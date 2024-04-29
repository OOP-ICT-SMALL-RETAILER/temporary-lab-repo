using MediatR;
using RetailThings.Application.Models.PickUpPoint;

namespace RetailThings.Application.Events.Commands.PickUp;

public class CreatePickUpCommand : IRequest
{
    public required CreatePickUpPointModel PickUpPoint { get; set; }
}
