using MediatR;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Queries.User;

namespace RetailThings.Application.Events.Handlers.User;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, Models.Entities.User?>
{
    private readonly IUserService _userService;

    public GetUserQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<Models.Entities.User?> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        return await _userService.GetUserById(request.UserId);
    }
}
