
using LPR.DAL.CoreDB;
using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories;
using LPR.DAL.Repositories.Generic;

namespace LPR.DAL.Repositories
{
    public class DateRepository : GenericRepository<DateAvailability>, IDateRepository
    {
        public DateRepository(LrpContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddDateByProfesionnalId(Guid profesionnalId, DateAvailability date)
        {
            date.ProfesionnalId = profesionnalId;
            dbContext.Add(date);
            dbContext.SaveChanges();
        }
        public List<DateAvailability> getDatesByProfesionnalId(Guid profesionnalId)
        {
            return  dbContext.DateAvailabilities
                    .Where(x=>x.ProfesionnalId == profesionnalId && x.IsDeleted == false)
                    .ToList();
        }

    }
}
