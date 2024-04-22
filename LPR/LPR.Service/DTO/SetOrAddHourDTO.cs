using LPR.Helper.Validators;

namespace LPR.Service.DTO
{
    public class SetOrAddHourDTO
    {
        [HourValidation(ErrorMessage = "Heure n'est pas valide")]
        public required string Label { get; set; }
    }
}
