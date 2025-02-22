using Fvent.API;
using Fvent.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddController()
    .AddService(builder.Configuration);

builder.Logging.AddConsole();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
