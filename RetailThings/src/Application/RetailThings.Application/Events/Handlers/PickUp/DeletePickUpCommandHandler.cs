using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.PickUp;

namespace RetailThings.Application.Events.Handlers.PickUp;

public class DeletePickUpCommandHandler: IRequestHandler<DeletePickUpCommand>
{
    private readonly IPickUpPointService _pickUpPointService;

    public DeletePickUpCommandHandler(IPickUpPointService pickUpPointService)
    {
        _pickUpPointService = pickUpPointService;
    }

    public async Task Handle(DeletePickUpCommand request, CancellationToken cancellationToken)
    {
        await _pickUpPointService.DeletePickUpPoint(request.PickUpPointId);
    }
}
