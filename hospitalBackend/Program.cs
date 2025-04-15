using hospitalBackend.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("default", options =>
    {
        options.AllowAnyHeader().AllowAnyOrigin().AllowAnyOrigin();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("default");

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();
