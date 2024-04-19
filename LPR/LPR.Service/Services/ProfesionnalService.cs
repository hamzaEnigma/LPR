using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories;
using LPR.Service.DTO;
using LPR.Service.IServices;

namespace LPR.Service.Services
{
    public class ProfesionnalService : IProfesionnalService
    {
        private readonly IProfesionnalRepository profesionnalRepository;
        private readonly IDateRepository dateRepository;

        public ProfesionnalService(IProfesionnalRepository profesionnalRepository,IDateRepository dateRepository)
        {
            this.profesionnalRepository = profesionnalRepository;
            this.dateRepository = dateRepository;
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
        public List<DateDTO> getProfesionnalAvailability(Guid id)
        {
            var pro =  profesionnalRepository.GetSingleBy(x=>x.Id == id).Result;
            var proDates = dateRepository.getDatesByProfesionnalId(id,true);
            var result = ToListDateDTOMap(proDates);
            return result;

        }

        private GetProfesionnalAvailabilityDTO? MapProfesionnalAvailability(Professional pro, List<DateAvailability> datesEntities)
        {
            return null;
        }
        public static HourDTO ToHourDTOMap(HourAvailability hourEntity)
        {
            return new HourDTO()
            {
                Id = hourEntity.Id,
                Label = hourEntity.Label
            };
        }
        public static List<HourDTO> ToListHourDTOMap(List<HourAvailability> hourEntities)
        {
            var list = new List<HourDTO>();
            hourEntities.ForEach(x =>
            {
                list.Add(ToHourDTOMap(x));
            });
            return list;
        }
        public static DateDTO ToDateDTOMap(DateAvailability dateEntity)
        {
            return new DateDTO()
            {
                IdDate = dateEntity.Id,
                Label = dateEntity.Label,
                HoursDto = ToListHourDTOMap(dateEntity?.HoursAvailabilities)
            };
        }
        public static List<DateDTO> ToListDateDTOMap(List<DateAvailability> dateEntities)
        {
            var list = new List<DateDTO>();
            dateEntities.ForEach(x =>
            {
                list.Add(ToDateDTOMap(x));
            });
            return list;
        }
    }
}
