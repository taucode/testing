﻿using FluentValidation;

namespace TauCode.Testing.Tests.Core.Features.Currencies.DeleteCurrency;

public class DeleteCurrencyCommandValidator : AbstractValidator<DeleteCurrencyCommand>
{
    public DeleteCurrencyCommandValidator()
    {
        this.CascadeMode = CascadeMode.Stop;

        this.RuleFor(x => x.Id)
            .LongId()
            .NotPredefinedCurrencyId()
            .WithName(nameof(DeleteCurrencyCommand.Id));
    }
}