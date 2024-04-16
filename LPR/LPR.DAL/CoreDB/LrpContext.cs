using LPR.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LPR.DAL.CoreDB
{
    public class LrpContext : DbContext
    {
        public LrpContext(DbContextOptions options) : base(options) { }

        public DbSet<Professional> Profesionnals { get; set; }

    }
}
