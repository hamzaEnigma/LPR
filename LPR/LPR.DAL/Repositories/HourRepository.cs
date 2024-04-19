using LPR.DAL.CoreDB;
using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories;
using LPR.DAL.Repositories.Generic;

namespace LPR.DAL.Repositories
{
    public class HourRepository : GenericRepository<HourAvailability>, IHourRepository
    {
        public HourRepository(LrpContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddHoursByDateId(HourAvailability hour)
        {
            dbContext.Add(hour);
            dbContext.SaveChanges();
        }

        public List<DateAvailability> getHoursByDateId(Guid profesionnalId)
        {
            throw new NotImplementedException();
        }
    }
}
