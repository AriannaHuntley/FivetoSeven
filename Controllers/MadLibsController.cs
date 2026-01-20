using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiveToSeven.Services;

namespace FivetoSeven.Controllers;


    [ApiController]
    [Route("api/[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibService _service;

        public MadLibController(MadLibService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get(string name, string place, string verb)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(place) ||
                string.IsNullOrWhiteSpace(verb))
            {
                return BadRequest("All inputs are required.");
            }

            return Ok(_service.CreateStory(name, place, verb));
        }
    }


