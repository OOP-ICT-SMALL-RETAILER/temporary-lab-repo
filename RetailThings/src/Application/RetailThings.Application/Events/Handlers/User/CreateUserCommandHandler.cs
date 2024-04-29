using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.User;

namespace RetailThings.Application.Events.Handlers.User;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
{
    private readonly IUserService _userService;

    public CreateUserCommandHandler(IUserService userService)
    {
        _userService = userService;
    }
    
    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        await _userService.CreateUser(request.CreateUserModel);
    }
}
