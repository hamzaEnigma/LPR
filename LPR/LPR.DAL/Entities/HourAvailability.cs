
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LPR.DAL.Entities.CommonEntities;

namespace LPR.DAL.Entities
{
    public class HourAvailability : EntityBase
    {
        [Key]
        [Column("hou_Id")]
        public Guid Id { get; set; }

        [Column("hou_Label")]
        public required string Label { get; set; }

        [Column("hou_fk_Date")]
        public required Guid DateId { get; set; }

        [ForeignKey(nameof(DateId))]
        public DateAvailability? Date { get; set; }
    }
}
