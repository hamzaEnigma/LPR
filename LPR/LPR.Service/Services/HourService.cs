using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories;
using LPR.Service.DTO;
using LPR.Service.IServices;

namespace LPR.Service.Services
{
    public class HourService : IHourService
    {
        private readonly IHourRepository hourRepository;

        public HourService(IHourRepository hourRepository)
        {
            this.hourRepository = hourRepository;
        }
        public void addHoursAvailability(DateAvailabiltyHoursDTO dateHoursAvailabilities)
        {
            dateHoursAvailabilities?.AvailabilityHours?.ForEach(x =>
            {
                hourRepository.AddHoursByDateId(
                    new HourAvailability()
                    {
                        Id = new Guid(),
                        Label = x.Label,
                        DateId = dateHoursAvailabilities.DateId
                    });
            });
        }

        public List<HourDTO> getHourAvailabilityByDateId(Guid dateId)
        {
            throw new NotImplementedException();
        }
    }
}
