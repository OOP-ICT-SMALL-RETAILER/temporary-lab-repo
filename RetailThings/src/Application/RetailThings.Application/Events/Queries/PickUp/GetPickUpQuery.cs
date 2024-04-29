using MediatR;
using RetailThings.Application.Models.Entities;

namespace RetailThings.Application.Events.Queries.PickUp;

public class GetPickUpQuery : IRequest<PickUpPoint?>
{
    public required int PickUpPointId { get; set; }
}
