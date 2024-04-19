using LPR.Service.DTO;
using LPR.Service.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LPR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {
        private readonly IDateService dateService;

        public AvailabilityController(IDateService dateService)
        {
            this.dateService = dateService;
        }

        // GET: api/<AvailabilityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        [Route("GetByProfesionnalId/{id}")]
        public string GetByProfesionnalId(Guid id)
        {
            return "value";
        }

        // POST api/<AvailabilityController>
        [HttpPost]
        public IActionResult Post([FromBody] ProfesionnalAvailabilityDatesDTO profesionnalAvailabilityDatesDTO)
        {
            dateService.addDateAvailability(profesionnalAvailabilityDatesDTO);
            return Ok();
        }

        // PUT api/<AvailabilityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AvailabilityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
