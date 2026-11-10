using Booking.Interfaces;

namespace Booking.Services;

public class TestService(BookingsContext dbContext) : ITestService
{
    public bool HelloDatabase()
    {
        return dbContext.TestEntities.Any();
    }

    public string HelloWorld()
    {
        return "AHHHHHHHHHH IM BURNING";
    }
}