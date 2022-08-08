using TauCode.Testing.Tests.Core.Features;

namespace TauCode.Testing.Tests.Core;

internal static class CoreHelper
{
    internal static bool UniqueCurrencyCodes(IList<SetupSystemCurrencyRate> currencyRates)
    {
        var codes = currencyRates.Select(x => x?.CurrencyCode).ToList();
        return codes.Count == codes.Distinct().ToList().Count;
    }
}