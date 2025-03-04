using GreetingApp.Repositories;
using GreetingApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Register layers
builder.Services.AddScoped<IGreetingRepository, GreetingRepository>();
builder.Services.AddScoped<IGreetingService, GreetingService>();

builder.Services.AddControllers();
// Enable Swagger for API testing
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
