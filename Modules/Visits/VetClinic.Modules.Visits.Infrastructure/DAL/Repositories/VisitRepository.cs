using Microsoft.EntityFrameworkCore;
using VetClinic.Modules.Visits.Application.Repositories;
using VetClinic.Modules.Visits.Core.Entities;

namespace VetClinic.Modules.Visits.Infrastructure.DAL.Repositories;

public class VisitRepository : IVisitRepository
{
    private readonly VisitsDbContext _dbContext;
    private readonly DbSet<Visit> _visits;

    public VisitRepository(VisitsDbContext dbContext)
    {
        _dbContext = dbContext;
        _visits = dbContext.Visits;
    }

    public async Task AddAsync(Visit visit, CancellationToken cancellationToken)
    {
        await _dbContext.AddAsync(visit, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<Visit?> GetByIdAsync(Guid visitId, CancellationToken cancellationToken)
    {
        var visit = await _visits.FirstOrDefaultAsync(x => x.Id == visitId, cancellationToken);
        return visit;
    }

    public async Task<IEnumerable<Visit>> GetAllVisits(CancellationToken cancellationToken)
    {
        return await _visits.ToListAsync(cancellationToken);
    }

    public async Task DeleteAsync(Visit visit, CancellationToken cancellationToken)
    {
        _visits.Remove(visit);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task CommitAsync(CancellationToken cancellationToken)
    {
       await _dbContext.SaveChangesAsync(cancellationToken);
    }
}