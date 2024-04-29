using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Queries.Review;
using RetailThings.Application.Models.Review;

namespace RetailThings.Application.Events.Handlers.Review;

public class GetReviewQueryHandler : IRequestHandler<GetReviewQuery, GetReviewModel?>
{
    private readonly IReviewService _reviewService;

    public GetReviewQueryHandler(IReviewService reviewService)
    {
        _reviewService = reviewService;
    }
    public async Task<GetReviewModel?> Handle(GetReviewQuery request, CancellationToken cancellationToken)
    {
        return await _reviewService.GetReviewById(request.ReviewId);
    }
}
