

using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using VetClinic.Modules.Users.Application.Interfaces.Authentication;
using VetClinic.Modules.Users.Application.Repositories;
using VetClinic.Modules.Users.Infrastructure.Authentication;
using VetClinic.Modules.Users.Infrastructure.DAL;
using VetClinic.Modules.Users.Infrastructure.DAL.Repositories;
using VetClinic.Shared.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using VetClinic.Modules.Users.Infrastructure.DAL.Initializers;
using VetClinic.Shared.Initializer;

namespace VetClinic.Modules.Users.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureLayer(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IPasswordHasher, PasswordHasher>();
        services.AddPostgres<UsersDbContext>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddTransient<IInitializer, UserInitializer>();

        var jwtSettings = new JwtSettings();
        configuration.GetSection(JwtSettings.SectionName).Bind(jwtSettings);
       
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings.Issuer,
                    ValidAudience = jwtSettings.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret)),
                };
            });
        
        return services;
    }
}

