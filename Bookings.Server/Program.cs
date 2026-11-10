using Booking.Interfaces;
using Booking.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITestService, TestService>();

builder.Services.AddControllers();

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

// app.UseAuthentication();
// app.UseAuthorization();

app.MapControllers();


app.Run();
