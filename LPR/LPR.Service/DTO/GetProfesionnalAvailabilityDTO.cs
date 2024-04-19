using System.ComponentModel;

namespace LPR.Service.DTO
{
    public class GetProfesionnalAvailabilityDTO
    {
        [ReadOnly(true)]
        public List<DateDTO>? AvailabilityDates { get; set; }
    }
}
