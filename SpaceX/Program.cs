using Microsoft.Extensions.DependencyInjection;
using SpaceX.Interface;
using SpaceX.Service;

var builder = WebApplication.CreateBuilder(args);

// register services
builder.Services.AddScoped<IApplicationService, ApplicationService>();

var app = builder.Build();

// resolve + run job
using var scope = app.Services.CreateScope();
var svc = scope.ServiceProvider.GetRequiredService<IApplicationService>();

await svc.ApplicationRun();

