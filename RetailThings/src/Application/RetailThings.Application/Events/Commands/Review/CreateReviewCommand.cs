using MediatR;
using RetailThings.Application.Models.Review;

namespace RetailThings.Application.Events.Commands.Review;

public class CreateReviewCommand : IRequest
{
    public required CreateReviewModel CreateReviewModel { get; set; }
}
