using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories.IGeneric;

namespace LPR.DAL.Interfaces.IRepositories
{
    public interface IHourRepository : IGenericRepository<HourAvailability>
    {
        void AddHoursByDateId(HourAvailability hour);
        List<DateAvailability> getHoursByDateId(Guid profesionnalId);
    }
}
