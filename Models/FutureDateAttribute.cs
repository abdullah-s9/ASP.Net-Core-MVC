using System.ComponentModel.DataAnnotations;

namespace SaudiGuide.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date = (DateTime)value;
            return date > DateTime.Now;
        }
    }
}
