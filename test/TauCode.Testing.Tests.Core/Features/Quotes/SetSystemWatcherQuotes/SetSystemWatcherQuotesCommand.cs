namespace TauCode.Testing.Tests.Core.Features.Quotes.SetSystemWatcherQuotes;

public class SetSystemWatcherQuotesCommand
{
    public long WatcherId { get; set; }
    public DateTimeOffset? Date { get; set; }
    public IList<SetupSystemCurrencyRate> CurrencyRates { get; set; }
}