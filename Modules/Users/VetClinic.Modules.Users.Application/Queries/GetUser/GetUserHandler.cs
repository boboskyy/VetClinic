using MediatR;
using VetClinic.Modules.Users.Application.DTO;
using VetClinic.Modules.Users.Application.Exceptions;
using VetClinic.Modules.Users.Application.Queries.Login;
using VetClinic.Modules.Users.Application.Repositories;
using VetClinic.Modules.Users.Shared.DTO;

namespace VetClinic.Modules.Users.Application.Queries.GetUser;

public class GetUserHandler :
    IRequestHandler<GetUserQuery, AuthenticationResultDto>
{
    private readonly IUserRepository _userRepository;

    public GetUserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<AuthenticationResultDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetAsync(request.UserId);
        if (user is null)
        {
            throw new UserNotFoundException(request.UserId);
        }

        return new AuthenticationResultDto(new UserDto() {Id = user.Id, Email = user.Email}, request.Token);
    }
}