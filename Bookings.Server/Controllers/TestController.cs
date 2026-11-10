using Booking.Interfaces;
using Booking.Services;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers;

[Route("api/[controller]/[action]")]
public class TestsController(ITestService testService) : Controller
{
    public string HelloWorld()
    {
        
        return "Hello!";
    }

    public string HelloService()
    {
        return testService.HelloWorld();
    }
}