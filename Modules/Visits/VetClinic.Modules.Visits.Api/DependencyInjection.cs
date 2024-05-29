using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VetClinic.Modules.Visits.Application;
using VetClinic.Modules.Visits.Infrastructure;

namespace VetClinic.Modules.Visits.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddVisitsModule(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApplicationLayer();
        services.AddInfrastructureLayer(configuration);
        return services;
    }
    
    public static IApplicationBuilder UserVisitsModule(this IApplicationBuilder app)
    {
        return app;
    }
}
