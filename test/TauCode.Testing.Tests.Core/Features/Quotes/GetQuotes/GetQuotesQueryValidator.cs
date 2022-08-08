using FluentValidation;
using TauCode.Testing.Tests.Core.Validators;

namespace TauCode.Testing.Tests.Core.Features.Quotes.GetQuotes;

public class GetQuotesQueryValidator : AbstractValidator<GetQuotesQuery>
{
    public GetQuotesQueryValidator()
    {
        this.CascadeMode = CascadeMode.Stop;

        this.RuleFor(x => x.WatcherId)
            .LongId();

        this.RuleFor(x => x.Date)
            .WrapValueTypeValidator(new QuoteDateValidator<GetQuotesQuery>());
    }
}