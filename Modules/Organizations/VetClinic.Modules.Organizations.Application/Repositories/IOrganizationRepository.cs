using VetClinic.Modules.Organizations.Domain.Entities;
using VetClinic.Modules.Organizations.Domain.ValueObjects;

namespace VetClinic.Modules.Organizations.Application.Repositories;

public interface IOrganizationRepository
{
    Task<Organization> GetAsync(OrganizationId id);
    Task<IEnumerable<Organization>> GetByAddressList(IEnumerable<string> addresses);
    Task<IEnumerable<Organization>> BrowseAsync();
    Task AddAsync(Organization organization);
    Task UpdateAsync(Organization organization);
    Task DeleteAsync(Organization organization);
}