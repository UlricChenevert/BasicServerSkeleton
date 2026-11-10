using Booking.Interfaces;
using Booking.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var dbPath = Path.Combine(builder.Environment.ContentRootPath, "Bookings.Database", "booking.db");

builder.Services.AddDbContext<BookingsContext>(options =>
    options.UseSqlite($"Data Source={dbPath}"));

builder.Services.AddScoped<ITestService, TestService>();

builder.Services.AddControllers();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<BookingsContext>().Database.Migrate();
}

app.MapGet("/", () => "Hello from base path!");

app.MapControllers();

app.Run();
