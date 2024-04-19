
using System.ComponentModel;

namespace LPR.Service.DTO
{
    public class GetDateAvailabilityDTO
    {
        [ReadOnly(true)]
        public Guid? Id { get; set; }

        [ReadOnly(true)]
        public string? Label { get; set; }

        [ReadOnly(true)]
        public List<HourDTO>? AvailabilityHours { get; set; }

    }
}
