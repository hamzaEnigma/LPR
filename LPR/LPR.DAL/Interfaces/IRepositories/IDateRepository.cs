using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories.IGeneric;

namespace LPR.DAL.Interfaces.IRepositories
{
    public interface IDateRepository : IGenericRepository<DateAvailability>
    {
        void AddDateByProfesionnalId(Guid profesionnalId, DateAvailability date);
        List<DateAvailability> getDatesByProfesionnalId(Guid profesionnalId);
    }
}
