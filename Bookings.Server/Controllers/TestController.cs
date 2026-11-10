using Microsoft.AspNetCore.Mvc;

namespace Booking.controllers;

[Route("api/[controller]/[action]")]
public class TestsController : Controller
{
    public string HelloWorld()
    {
        
        return "Hello!";
    }
}