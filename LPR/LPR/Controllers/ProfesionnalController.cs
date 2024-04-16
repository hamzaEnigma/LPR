using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LPR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesionnalController : ControllerBase
    {
        private readonly IProfesionnalRepository profesionnalRepository;

        public ProfesionnalController(IProfesionnalRepository profesionnalRepository)
        {
            this.profesionnalRepository = profesionnalRepository;
        }
        // GET: api/<ProfesionnalController>
        [HttpGet]
        public IEnumerable<Professional> Get()
        {
            return profesionnalRepository.GetAll();
        }

        // GET api/<ProfesionnalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProfesionnalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProfesionnalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProfesionnalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
