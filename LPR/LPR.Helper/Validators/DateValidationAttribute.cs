using LPR.Helper.Enums;
using System.ComponentModel.DataAnnotations;

namespace LPR.Helper.Validators
{
    public class DateValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string? strValue = value as string;
            DateConfig dates = new DateConfig();
            if (!dates.datesOfWeek.Contains(strValue))
            {
                return false;
            }
            return true;
        }
    }
}
