using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.PickUp;

namespace RetailThings.Application.Events.Handlers.PickUp;

public class CreatePickUpCommandHandler : IRequestHandler<CreatePickUpCommand>
{
    private readonly IPickUpPointService _pickUpPointService;

    public CreatePickUpCommandHandler(IPickUpPointService pickUpPointService)
    {
        _pickUpPointService = pickUpPointService;
    }

    public async Task Handle(CreatePickUpCommand request, CancellationToken cancellationToken)
    {
        await _pickUpPointService.CreatePickUpPoint(request.PickUpPoint);
    }
}
