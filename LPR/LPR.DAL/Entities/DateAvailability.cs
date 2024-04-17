using LPR.DAL.Entities.CommonEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LPR.DAL.Entities
{
    public class DateAvailability : EntityBase
    {
        [Key]
        [Column("dat_Id")]
        public Guid Id { get; set; }

        [Column("dat_Label")]
        public required string Label { get; set; }

        [Column("dat_RealDate")]
        public required DateTime RealDate { get; set; }

        [Column("dat_fk_Profesionnal")]
        public Guid ProfesionnalId { get; set; }

        [ForeignKey(nameof(ProfesionnalId))]
        public virtual Professional? Professional { get; set; }
        public virtual List<HourAvailability>? HoursAvailabilities { get; set; }

    }
}
