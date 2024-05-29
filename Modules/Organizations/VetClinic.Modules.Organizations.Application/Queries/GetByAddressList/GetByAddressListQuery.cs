using MediatR;
using VetClinic.Modules.Organizations.Application.DTO;
using VetClinic.Modules.Organizations.Application.Queries.GetByAddressList.DTO;

namespace VetClinic.Modules.Organizations.Application.Queries.GetByAddressList;

public record GetByAddressListQuery
(
    IEnumerable<string> Addresses
): IRequest<GetByAddressListDto>;