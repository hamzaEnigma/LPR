using LPR.Helper.Validators;

namespace LPR.Service.DTO
{
    public class SetOrAddDateDTO
    {
        [DateValidation(ErrorMessage ="Date n'est pas valide")]
        public required string Label { get; set; }
        public List<SetOrAddHourDTO>? HoursDto { get; set; }
    }
}
