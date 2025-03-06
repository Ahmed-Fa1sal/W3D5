using ECommerceAPI.Services;  // Correct namespace for ProductServices
using Microsoft.AspNetCore.Builder;  // For WebApplication methods
using Microsoft.Extensions.DependencyInjection;  // For IServiceCollection
using Microsoft.Extensions.Hosting;  // For IWebHostEnvironment

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ProductServices>(); // Register ProductServices for Dependency Injection
builder.Services.AddControllers(); // Add controller services

// Add Swagger
builder.Services.AddEndpointsApiExplorer(); // Required for Swagger
builder.Services.AddSwaggerGen(); // Add Swagger generation

var app = builder.Build(); // Build the WebApplication

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Enable Swagger
    app.UseSwaggerUI(); // Enable Swagger UI in development
}

app.UseHttpsRedirection(); // Enforce HTTPS

app.MapControllers(); // Map the controllers for the API endpoints

app.Run(); // Run the application