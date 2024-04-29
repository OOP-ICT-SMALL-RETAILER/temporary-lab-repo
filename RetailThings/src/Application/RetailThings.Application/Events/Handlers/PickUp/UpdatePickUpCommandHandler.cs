using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.PickUp;

namespace RetailThings.Application.Events.Handlers.PickUp;

public class UpdatePickUpCommandHandler : IRequestHandler<UpdatePickUpCommand>
{
    private readonly IPickUpPointService _pickUpPointService;

    public UpdatePickUpCommandHandler(IPickUpPointService pickUpPointService)
    {
        _pickUpPointService = pickUpPointService;
    }

    public async Task Handle(UpdatePickUpCommand request, CancellationToken cancellationToken)
    {
        await _pickUpPointService.UpdatePickUpPoint(request.PickUpPoint);
    }
}
