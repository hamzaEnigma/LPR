using System.ComponentModel.DataAnnotations.Schema;

namespace LPR.Service.DTO
{
    public class DateDTO
    {
        public Guid? IdDate { get; set; }

        public required string Label { get; set; }

        public  DateTime? RealDate { get; set; }
        [NotMapped]
        public Guid? ProfesionnalId { get; set; }

        public List<HourDTO>? HoursDto { get; set; }
    }
}
