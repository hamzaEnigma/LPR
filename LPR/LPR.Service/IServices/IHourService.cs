using LPR.Service.DTO;

namespace LPR.Service.IServices
{
    public interface IHourService
    {
        void addHoursAvailability(DateAvailabiltyHoursDTO dateHoursAvailabilities);
        List<HourDTO> getHourAvailabilityByDateId(Guid dateId);
    }
}
