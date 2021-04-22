using System;
using System.Collections.Generic;
using System.Linq;
using TauCode.Testing.Tests.Core;

namespace TauCode.Testing.Tests
{
    internal static class TestHelper
    {
        internal static Guid? ToNullableGuid(this string guidString)
        {
            if (guidString == null)
            {
                return null;
            }

            return new Guid(guidString);
        }

        public static IList<string> GetPredefinedCurrencyCodes() =>
            DataConstants.Currency.PredefinedCurrenciesByCode.Keys.ToList();

        public static IList<long> GetPredefinedCurrencyIds() =>
            DataConstants.Currency.PredefinedCurrenciesById.Keys.ToList();
    }
}
