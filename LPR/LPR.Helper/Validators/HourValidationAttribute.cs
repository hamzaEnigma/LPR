using LPR.Helper.ConfigData;
using LPR.Helper.Enums;
using System.ComponentModel.DataAnnotations;

namespace LPR.Helper.Validators
{
    public class HourValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string? strValue = value as string;
            HourConfig hours = new HourConfig();
            if (!hours.hoursOfDay.Contains(strValue))
            {
                return false;
            }
            return true;
        }
    }
}
