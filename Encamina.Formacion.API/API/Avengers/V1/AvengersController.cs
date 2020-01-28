using Encamina.Formacion.API.Domain;
using Encamina.Formacion.API.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Encamina.Formacion.API.API.Avengers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvengersController : ControllerBase
    {

        private readonly IAvengerDomain avengerDomain;

        public AvengersController(IAvengerDomain avengerDomain)
        {
            this.avengerDomain = avengerDomain;
        }


        [HttpGet(Name = "Get All Avengers")]
        public async Task<IActionResult> Get()
        {
            var result = await avengerDomain.GetAllAsync();
            return Ok(result);
        }


        [HttpGet("{id}", Name = "GetByIDAvenger")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await avengerDomain.GetByIdAsync(id);
            return Ok(result);
        }


        [HttpGet("{id}/films", Name = "GetByFilmsIDAvenger")]
        public async Task<IActionResult> GetFilmsById(int id)
        {


            var result = await avengerDomain.GetAllFilmsByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Avenger avenger)
        {
            var result = await avengerDomain.InsertAsync(avenger);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Avenger avenger)
        {
            var result = await avengerDomain.UpdateAsync(avenger);
            if (!result)
            {
                return NotFound();
            }
            return Ok(true);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await avengerDomain.DeleteAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return Ok(true);
        }
    }
}