using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FivetoSeven.Services;
using Microsoft.AspNetCore.Mvc;

namespace FivetoSeven.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReverseAlphaController : ControllerBase
    {
        private readonly ReverseAlphaService _service;

        public ReverseAlphaController(ReverseAlphaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return BadRequest("Input cannot be empty.");

            return Ok($"You entered {input}, reversed is {_service.Reverse(input)}");
        }
    }

}