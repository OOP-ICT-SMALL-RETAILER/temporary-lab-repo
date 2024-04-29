using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Queries.PickUp;
using RetailThings.Application.Models.Entities;

namespace RetailThings.Application.Events.Handlers.PickUp;

public class GetPickUpPointQueryHandler : IRequestHandler<GetPickUpQuery, PickUpPoint?>
{
    private readonly IPickUpPointService _pickUpPointService;

    public GetPickUpPointQueryHandler(IPickUpPointService pickUpPointService)
    {
        _pickUpPointService = pickUpPointService;
    }

    public async Task<PickUpPoint?> Handle(GetPickUpQuery request, CancellationToken cancellationToken)
    {
        return await _pickUpPointService.GetPickUpPointById(request.PickUpPointId);
    }
}
