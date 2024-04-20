namespace LPR.Service.DTO
{
    public class SetOrAddDateDTO
    {
        public required string Label { get; set; }
        public List<SetOrAddHourDTO>? HoursDto { get; set; }
    }
}
