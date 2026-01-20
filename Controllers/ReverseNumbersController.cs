using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FivetoSeven.Services;
using Microsoft.AspNetCore.Mvc;

namespace FivetoSeven.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class ReverseNumbersController : ControllerBase
    {
        private readonly ReverseNumbersService _service;

        public ReverseNumbersController(ReverseNumbersService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get(string numbers)
        {
            if (!numbers.All(char.IsDigit))
                return BadRequest("Numbers only.");

            return Ok($"You entered {numbers}, reversed is {_service.ReverseNumbers(numbers)}");
        }
    }
