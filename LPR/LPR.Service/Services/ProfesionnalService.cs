using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories;
using LPR.Service.DTO;
using LPR.Service.IServices;

namespace LPR.Service.Services
{
    public class ProfesionnalService : IProfesionnalService
    {
        private readonly IProfesionnalRepository profesionnalRepository;

        public ProfesionnalService(IProfesionnalRepository profesionnalRepository)
        {
            this.profesionnalRepository = profesionnalRepository;
        }
        public void AddProfesionnal(ProfesionnalDTO profesionnalDTO)
        {
            var ProfesionnalEntity = new Professional()
            {
                Id = new Guid(),
                FirstName = profesionnalDTO.FirstName,
                gender = profesionnalDTO.gender
            };
            profesionnalRepository.Add(ProfesionnalEntity);
            profesionnalRepository.Save();
        }

        public List<ProfesionnalDTO>? GetAll()
        {
            var profesionnalDTOs = new List<ProfesionnalDTO>();
            profesionnalRepository.GetAll().ForEach(x =>
               {
                   profesionnalDTOs.Add(new ProfesionnalDTO()
                   {
                       Id = x.Id,
                       FirstName = x.FirstName,
                       gender = x.gender
                   });
               });
            return profesionnalDTOs;
        }

        public ProfesionnalDTO? GetProfesionnalById(Guid id)
        {
            var profesionnal = profesionnalRepository.GetSingleNonTrackingBy(x => x.Id == id && x.IsDeleted == false);
                return new ProfesionnalDTO
                {
                    Id = profesionnal.Id,
                    FirstName = profesionnal.FirstName,
                    gender = profesionnal.gender,
                };
        }
    }
}
