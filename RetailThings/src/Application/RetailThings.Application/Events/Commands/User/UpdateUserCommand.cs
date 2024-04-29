using MediatR;
using RetailThings.Application.Models.User;

namespace RetailThings.Application.Events.Commands.User;

public class UpdateUserCommand : IRequest
{
    public required CreateUserModel UpdateUserModel { get; set; }
}
