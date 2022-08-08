using FluentValidation;
using TauCode.Testing.Tests.Core.Validators;

namespace TauCode.Testing.Tests.Core.Features.Watchers.GetWatcherCurrencies;

public class GetWatcherCurrenciesQueryValidator : AbstractValidator<GetWatcherCurrenciesQuery>
{
    public GetWatcherCurrenciesQueryValidator()
    {
        this.CascadeMode = CascadeMode.Stop;

        this.RuleFor(x => x.WatcherId)
            .LongId()
            .NotEqual(DataConstants.SystemWatcher.DefaultSystemWatcherId);

        this.RuleFor(x => x.Date)
            .WrapValueTypeValidator(new QuoteDateValidator<GetWatcherCurrenciesQuery>());
    }
}