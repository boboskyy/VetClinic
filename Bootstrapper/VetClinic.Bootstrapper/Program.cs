using VetClinic.Shared;
using VetClinic.Modules.Visits.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddVisitsModule(builder.Configuration)
    .AddSharedFramework(builder.Configuration);

var app = builder.Build();

app.UseSharedFramework();
app.UserVisitsModule();

app.UseHttpsRedirection();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    app.UseSwagger();
    
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty; // Set Swagger UI at app's root
    });
});


app.Run();
