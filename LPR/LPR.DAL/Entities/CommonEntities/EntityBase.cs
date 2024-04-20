using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPR.DAL.Entities.CommonEntities
{
    public class EntityBase
    {
        public bool? IsDeleted { get; set; } = false;
        public virtual Guid? CreatedBy { get; set; }
        public virtual string? CreatedByUserName { get; set; } = "Admin";
        public Guid? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
    }
}
