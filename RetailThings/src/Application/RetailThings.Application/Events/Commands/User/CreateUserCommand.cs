using MediatR;
using RetailThings.Application.Models.User;

namespace RetailThings.Application.Events.Commands.User;

public class CreateUserCommand : IRequest
{
    public required CreateUserModel CreateUserModel { get; set; }
}
