using LPR.Service.DTO;
using LPR.Service.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LPR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HourAvailabityController : ControllerBase
    {
        private readonly IHourService hourService;

        public HourAvailabityController(IHourService hourService)
        {
            this.hourService = hourService;
        }

        // POST api/<HourController>
        [HttpPost]
        [Route("Add/{dateId}")]
        public void AddHoursAvailability(DateAvailabiltyHoursDTO dateAvailabiltyHours)
        {
            hourService.addHoursAvailability(dateAvailabiltyHours);
        }

        // GET: api/<HourController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HourController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // PUT api/<HourController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HourController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
