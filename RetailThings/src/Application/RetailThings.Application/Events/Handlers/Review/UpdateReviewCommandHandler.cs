using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.Review;

namespace RetailThings.Application.Events.Handlers.Review;

public class UpdateReviewCommandHandler : IRequestHandler<UpdateReviewCommand>
{
    private readonly IReviewService _reviewService;

    public UpdateReviewCommandHandler(IReviewService reviewService)
    {
        _reviewService = reviewService;
    }
    
    public async Task Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
    {
        await _reviewService.UpdateReview(request.UpdateReviewModel);
    }
}
