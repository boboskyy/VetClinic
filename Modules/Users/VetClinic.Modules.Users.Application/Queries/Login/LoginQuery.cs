using VetClinic.Modules.Users.Application.DTO;
using MediatR;

namespace VetClinic.Modules.Users.Application.Queries.Login;

public record LoginQuery(
    string Email,
    string Password
) : IRequest<AuthenticationResultDto>;

