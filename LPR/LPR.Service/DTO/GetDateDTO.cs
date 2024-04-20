namespace LPR.Service.DTO
{
    public class GetDateDTO
    {
        public Guid? IdDate { get; set; }
        public required string LabelDate { get; set; }
        public List<HourDTO>? HoursDto { get; set; }
    }
}
