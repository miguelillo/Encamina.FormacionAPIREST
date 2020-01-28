using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Encamina.Formacion.API.API.Avenger.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvengersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Avengers()
        {
            return Ok("Hulk");
        }
    }
}