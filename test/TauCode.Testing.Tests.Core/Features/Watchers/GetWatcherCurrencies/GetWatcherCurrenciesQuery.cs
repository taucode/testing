using System;

namespace TauCode.Testing.Tests.Core.Features.Watchers.GetWatcherCurrencies
{
    public class GetWatcherCurrenciesQuery
    {
        public long WatcherId { get; set; }
        public DateTimeOffset? Date { get; set; }
    }
}
