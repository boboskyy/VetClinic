using VetClinic.Modules.Visits.Core.Entities;

namespace VetClinic.Modules.Visits.Application.Repositories;

public interface IVisitRepository
{
    public Task AddAsync(Visit visit, CancellationToken cancellationToken);
    public Task<Visit?> GetByIdAsync(Guid visitId, CancellationToken cancellationToken);
    public Task<IEnumerable<Visit>> GetAllVisits(CancellationToken cancellationToken);
    public Task DeleteAsync(Visit visit, CancellationToken cancellationToken);
    public Task CommitAsync(CancellationToken cancellationToken);
}