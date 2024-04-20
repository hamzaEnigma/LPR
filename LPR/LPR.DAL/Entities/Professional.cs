using LPR.DAL.Entities.CommonEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LPR.DAL.Entities
{
    public class Professional : EntityBase
    {
        [Key]
        [Column("pro_Id")]
        public Guid Id { get; set; }

        [Column("pro_FirstName")]
        public required string FirstName { get; set; }

        [Column("pro_gender")]
        public string? gender { get; set; }
        public virtual List<DateAvailability>? DateAvailabilities { get; set; } = new List<DateAvailability>();

    }
}


