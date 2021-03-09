using System;
using System.ComponentModel.DataAnnotations;

namespace PhysicalTherapyProject.Application.Infrastructure.ValidationAttributes
{
    public class EnforceTrueAttribute : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            if (value == null) return false;
            if (value.GetType() != typeof(bool)) throw new InvalidOperationException("Can only be used on boolean properties.");

            return (bool)value;
        }
    }
}
