using MediatR;
using VetClinic.Modules.Users.Application.DTO;
using VetClinic.Modules.Users.Shared.DTO;

namespace VetClinic.Modules.Users.Application.Queries.GetUser;

public record GetUserQuery(Guid UserId, String Token) : IRequest<AuthenticationResultDto>;