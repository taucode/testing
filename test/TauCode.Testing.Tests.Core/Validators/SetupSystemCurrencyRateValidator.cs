using FluentValidation;
using TauCode.Testing.Tests.Core.Features;

namespace TauCode.Testing.Tests.Core.Validators;

public class SetupSystemCurrencyRateValidator : AbstractValidator<SetupSystemCurrencyRate>
{
    public SetupSystemCurrencyRateValidator()
    {
        this.CascadeMode = CascadeMode.Stop;

        this.RuleFor(x => x.CurrencyCode)
            .CurrencyCode()
            .NotEqual(DataConstants.Currency.SystemBasicCurrencyCode);

        this.RuleFor(x => x.Rate)
            .QuoteRate();
    }
}