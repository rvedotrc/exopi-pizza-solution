using Microsoft.AspNetCore.Mvc;

namespace PizzaPlace.Controllers;

[Route("api/welcome")]
public class WelcomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Greet()
    {
        Console.WriteLine("Greeted guest.");

        return Ok("Welcome to some automated pizza place or other.");
    }
}
