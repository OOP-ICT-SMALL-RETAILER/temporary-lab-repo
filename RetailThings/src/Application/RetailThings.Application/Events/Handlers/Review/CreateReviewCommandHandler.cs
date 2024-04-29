using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.Review;

namespace RetailThings.Application.Events.Handlers.Review;

public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand>
{
    private readonly IReviewService _reviewService;

    public CreateReviewCommandHandler(IReviewService reviewService)
    {
        _reviewService = reviewService;
    }
    
    public async Task Handle(CreateReviewCommand request, CancellationToken cancellationToken)
    {
        await _reviewService.CreateReview(request.CreateReviewModel);
    }
}
