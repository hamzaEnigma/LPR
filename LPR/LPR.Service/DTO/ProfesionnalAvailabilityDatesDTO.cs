namespace LPR.Service.DTO
{
    public class ProfesionnalAvailabilityDatesDTO
    {
        public Guid ProfesionnalId { get; set; }
        public List<DateDTO>? AvailabilityDates { get; set; }
    }
}
