using Microsoft.EntityFrameworkCore;
using GreetingApp.Repositories;
using GreetingApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Read connection string from configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register the DbContext using the Pomelo MySQL provider. 
// ServerVersion.AutoDetect analyzes the server version automatically.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Register repository and service layers using Scoped lifetime.
builder.Services.AddScoped<IGreetingRepository, GreetingRepository>();
builder.Services.AddScoped<IGreetingService, GreetingService>();

builder.Services.AddControllers();             // Add controllers as services.
builder.Services.AddEndpointsApiExplorer();    // Enable endpoint explorer.
builder.Services.AddSwaggerGen();              // Add Swagger generator (for development).

var app = builder.Build();

// Enable Swagger UI in development (optional since testing is via Postman)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();   // Enable authorization middleware if needed.
app.MapControllers();     // Map controller endpoints.
app.Run();                // Run the application.
