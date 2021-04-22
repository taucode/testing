using System;

namespace TauCode.Testing.Tests.Core.Features.Quotes.GetQuotes
{
    public class GetQuotesQuery
    {
        public long WatcherId { get; set; }

        public DateTimeOffset? Date { get; set; }
    }
}
