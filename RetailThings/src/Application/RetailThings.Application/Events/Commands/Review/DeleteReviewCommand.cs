using MediatR;

namespace RetailThings.Application.Events.Commands.Review;

public class DeleteReviewCommand : IRequest
{
    public required int ReviewId { get; set; }
}
