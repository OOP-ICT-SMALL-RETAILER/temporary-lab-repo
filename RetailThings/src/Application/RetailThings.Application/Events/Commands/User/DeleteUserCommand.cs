using MediatR;

namespace RetailThings.Application.Events.Commands.User;

public class DeleteUserCommand : IRequest
{
    public required int UserId { get; set; }
}
