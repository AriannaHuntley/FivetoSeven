using FivetoSeven.Services;
//  http://localhost:5053/api/OddOrEven/OddOrEven/8
using Microsoft.AspNetCore.Mvc;

namespace FivetoSeven.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OddOrEvenController : ControllerBase
{
    private readonly OddOrEvenService _service;

    public OddOrEvenController(OddOrEvenService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get(int number)
    {
        return Ok($"The number {number} is {_service.Check(number)}.");
    }
}
