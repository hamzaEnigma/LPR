using System.ComponentModel.DataAnnotations.Schema;

namespace LPR.Service.DTO
{
    public class DateDTO
    {
        public Guid? Id { get; set; }

        public required string Label { get; set; }

        public  DateTime? RealDate { get; set; }
        [NotMapped]
        public Guid? ProfesionnalId { get; set; }
    }
}
