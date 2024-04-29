using MediatR;

namespace RetailThings.Application.Events.Queries.User;

public class GetUserQuery : IRequest<Models.Entities.User?>
{
    public required int UserId { get; set; }
}
