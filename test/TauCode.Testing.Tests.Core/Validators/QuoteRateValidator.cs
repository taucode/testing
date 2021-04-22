using FluentValidation;
using FluentValidation.Validators;

namespace TauCode.Testing.Tests.Core.Validators
{
    public class QuoteRateValidator<T> : PropertyValidator<T, decimal>
    {
        public override bool IsValid(ValidationContext<T> context, decimal value)
        {
            return value > 0m;
        }

        public override string Name => "QuoteRateValidator";

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return "'{PropertyName}' must be positive.";
        }
    }
}
