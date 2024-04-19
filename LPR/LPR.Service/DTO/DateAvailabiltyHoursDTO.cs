namespace LPR.Service.DTO
{
    public class DateAvailabiltyHoursDTO
    {
        public Guid DateId { get; set; }
        public List<HourDTO>? AvailabilityHours { get; set; }
    }
}
