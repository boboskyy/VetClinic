using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VetClinic.Modules.Organizations.Application;
using VetClinic.Modules.Organizations.Infrastructure;
using VetClinic.Modules.Organizations.Infrastructure.DAL;

namespace VetClinic.Modules.Organizations.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddOrganizationsModule(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApplicationLayer();
        services.AddInfrastructureLayer(configuration);
        return services;
    }
    
    public static IApplicationBuilder UseOrganizationsModule(this IApplicationBuilder app)
    {
        return app;
    }
}
