using FluentValidation;
using FluentValidation.Validators;

namespace TauCode.Testing.Tests.Core.Features.Currencies.GetCurrency;

public class GetCurrencyQueryValidator : SinglePropertyValidator<GetCurrencyQuery>
{
    public GetCurrencyQueryValidator()
        : base(new Dictionary<string, IPropertyValidator>
        {
            { nameof(GetCurrencyQuery.Id), new LongIdValidator<GetCurrencyQuery>() },
            { nameof(GetCurrencyQuery.Code), new CurrencyCodeValidator<GetCurrencyQuery>() },
        })
    {
        this.CascadeMode = CascadeMode.Stop;
    }
}