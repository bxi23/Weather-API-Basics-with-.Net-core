// Create a builder for the web application
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// This adds the controllers to the dependency injection container.
builder.Services.AddControllers();

// Add services for API documentation and testing using Swagger.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Build the web application.
var app = builder.Build();

// Configure the HTTP request pipeline.
// This middleware is only added in the development environment.
if (app.Environment.IsDevelopment())
{
    // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwagger();
    // Enable middleware to serve Swagger UI, specifying the Swagger JSON endpoint.
    app.UseSwaggerUI();
}

// Redirect HTTP requests to HTTPS.
app.UseHttpsRedirection();

// Add authorization middleware to the request pipeline.
app.UseAuthorization();

// Map controller routes to the request pipeline.
app.MapControllers();

// Run the web application.
app.Run();