using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories;
using LPR.Service.DTO;
using LPR.Service.IServices;

namespace LPR.Service.Services
{
    public class DateService : IDateService
    {
        private readonly IDateRepository dateRepository;

        public DateService(IDateRepository dateRepository)
        {
            this.dateRepository = dateRepository;
        }
        public void addDateAvailability(ProfesionnalAvailabilityDatesDTO profesionnalAvailability)
        {
            profesionnalAvailability?.AvailabilityDates?.ForEach(x =>
            {
                dateRepository.AddDateByProfesionnalId(
                    profesionnalAvailability.ProfesionnalId,
                    new DateAvailability() {
                    Id = new Guid(),
                    Label = x.Label,
                    RealDate = DateTime.Now.Date,
                });
            });
        }
        public List<DateDTO> getDateAvailabilityByProfesionnalId(Guid profesionnalId)
        {
            var listDates = new List<DateDTO>();
            dateRepository.getDatesByProfesionnalId(profesionnalId).ForEach(x =>
            {
                listDates.Add(new DateDTO()
                {
                    Id = x.Id,
                    Label = x.Label,
                    RealDate = x.RealDate,

                });
            });
            return listDates;
        }
    }
}
