using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PhysicalTherapyProject.Application.Infrastructure.ValidationAttributes
{
    public class NotEqualAttribute : ValidationAttribute
    {
        private readonly string _notEqualTo;

        public NotEqualAttribute(string notEqualTo)
        {
            _notEqualTo = notEqualTo;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || object.Equals(value, _notEqualTo))
            {
                return new ValidationResult(ErrorMessage);
            } 
            return ValidationResult.Success;
        }
    }
}
