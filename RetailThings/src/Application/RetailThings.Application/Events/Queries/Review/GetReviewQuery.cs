using MediatR;
using RetailThings.Application.Models.Review;

namespace RetailThings.Application.Events.Queries.Review;

public class GetReviewQuery : IRequest<GetReviewModel?>
{
    public required int ReviewId { get; set; }
}
