﻿using FluentValidation;

namespace TauCode.Testing.Tests.Core.Features.Currencies.CreateCurrency;

public class CreateCurrencyCommandValidator : AbstractValidator<CreateCurrencyCommand>
{
    public CreateCurrencyCommandValidator()
    {
        this.CascadeMode = CascadeMode.Stop;

        this.RuleFor(x => x.Code)
            .CurrencyCode()
            .NotPredefinedCurrencyCode();

        this.RuleFor(x => x.Name)
            .FullName(1, DataConstants.Currency.MaxCurrencyNameLength, false);
    }
}