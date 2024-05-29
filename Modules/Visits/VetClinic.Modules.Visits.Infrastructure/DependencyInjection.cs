using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VetClinic.Modules.Visits.Application.Repositories;
using VetClinic.Modules.Visits.Infrastructure.DAL;
using VetClinic.Modules.Visits.Infrastructure.DAL.Repositories;
using VetClinic.Shared.Database;
using VetClinic.Shared.Initializer;

namespace VetClinic.Modules.Visits.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureLayer(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddPostgres<VisitsDbContext>();
        services.AddScoped<IVisitRepository, VisitRepository>();
        return services;
    }
}