using MediatR;
using RetailThings.Application.Models.Review;

namespace RetailThings.Application.Events.Commands.Review;

public class UpdateReviewCommand : IRequest
{
    public required CreateReviewModel UpdateReviewModel { get; set; }
}
