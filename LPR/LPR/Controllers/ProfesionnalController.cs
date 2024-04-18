using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories;
using LPR.Service.DTO;
using LPR.Service.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LPR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesionnalController : ControllerBase
    {
        private readonly IProfesionnalService profesionnalService;

        public ProfesionnalController(IProfesionnalService profesionnalService)
        {
            this.profesionnalService = profesionnalService;
        }

        [HttpPost]
        public void Post([FromBody] ProfesionnalDTO profesionnal)
        {
            this.profesionnalService.AddProfesionnal(profesionnal);
        }

        [HttpGet]
        [Route("GetAll")]
        public List<ProfesionnalDTO> GetAll()
        {
            return profesionnalService.GetAll();
        }

        [HttpGet("{id}")]

        public ProfesionnalDTO Get(Guid id)
        {
            return profesionnalService.GetProfesionnalById(id);
        }



        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
