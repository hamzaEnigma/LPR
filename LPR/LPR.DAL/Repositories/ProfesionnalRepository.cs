using LPR.DAL.CoreDB;
using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories;
using LPR.DAL.Interfaces.IRepositories.IGeneric;
using LPR.DAL.Repositories.Generic;
using System.Linq.Expressions;

namespace LPR.DAL.Repositories
{
    public class ProfesionnalRepository : GenericRepository<Professional> ,IProfesionnalRepository
    {
        public ProfesionnalRepository(LrpContext dbContext): base(dbContext)
        {
            this.dbContext = dbContext;
        }      
    }
}
