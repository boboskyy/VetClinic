using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VetClinic.Modules.Organizations.Application.Repositories;
using VetClinic.Modules.Organizations.Infrastructure.DAL;
using VetClinic.Modules.Organizations.Infrastructure.DAL.Repositories;
using VetClinic.Shared.Database;
using Microsoft.EntityFrameworkCore.Design;
using VetClinic.Modules.Organizations.Infrastructure.DAL.Initializers;
using VetClinic.Shared.Initializer;

namespace VetClinic.Modules.Organizations.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureLayer(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddPostgres<OrganizationsDbContext>();
        services.AddScoped<IOrganizationRepository, OrganizationRepository>();
        services.AddTransient<IInitializer, OrganizationInitializer>();
        return services;
    }
}