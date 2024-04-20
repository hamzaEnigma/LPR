using LPR.DAL.Entities.CommonEntities;

namespace LPR.DAL.Entities
{
    public class Appointement : EntityBase
    {
        public Guid Id { get; set; }
        public required Guid ProfesionnalId { get; set; }
        public virtual Professional? Professional { get; set; }
        public required string DateAppointement { get; set; }
        public required string HourAppointement { get; set; }
        public string? Motif { get; set; }
        public string? Comment { get; set; }

    }
}
