using Booking.Interfaces;
using Booking.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var dbPath = Path.Combine(builder.Environment.ContentRootPath, "Bookings.Database", "booking.db");
Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);

builder.Services.AddDbContext<BookingsContext>(options =>
    options.UseSqlite($"Data Source={dbPath}"));
builder.Services.AddScoped<ITestService, TestService>();

builder.Services.AddControllers();

var app = builder.Build();

// Apply any pending EF Core migrations so the schema always exists.
using (var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<BookingsContext>().Database.Migrate();
}


app.MapGet("/", () => "Hello World!");

// app.UseAuthentication();
// app.UseAuthorization();

app.MapControllers();


app.Run();
