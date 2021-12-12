using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Money;

namespace Monetize.Parsing
{
    public static class Parser
    {
        public static readonly List<KeyValuePair<string, Currency>> Currencies = new List<KeyValuePair<string, Currency>>
        {
            new KeyValuePair<string, Currency>("$", Currency.USD),
            new KeyValuePair<string, Currency>("€", Currency.EUR),
            new KeyValuePair<string, Currency>("£", Currency.GBP),
            new KeyValuePair<string, Currency>("₤", Currency.GBP),
            new KeyValuePair<string, Currency>("R$", Currency.BRL),
            new KeyValuePair<string, Currency>("R", Currency.ZAR),
            //new KeyValuePair<string, Currency>("¥", Currency.JPY),
            new KeyValuePair<string, Currency>("C$", Currency.CAD),
            new KeyValuePair<string, Currency>("₼", Currency.AZN),
            new KeyValuePair<string, Currency>("元", Currency.CNY),
            new KeyValuePair<string, Currency>("Kč", Currency.CZK),
            new KeyValuePair<string, Currency>("Ft", Currency.HUF),
            new KeyValuePair<string, Currency>("₹", Currency.INR),
            //new KeyValuePair<string, Currency>("₽", Currency.RUB),
            //new KeyValuePair<string, Currency>("₺", Currency.TRY),
            //new KeyValuePair<string, Currency>("₴", Currency.UAH),
            new KeyValuePair<string, Currency>("Fr", Currency.CHF),
            //new KeyValuePair<string, Currency>("zł", Currency.PLN),
            //new KeyValuePair<string, Currency>("₸", Currency.KZT),
            //new KeyValuePair<string, Currency>("₩", Currency.KRW)
        };

        public static (decimal, Currency) Parse(string input)
        {
            var amount = ParseAmount(input);
            var currency = ParseCurrency(input);

            return (amount, currency);
        }

        public static decimal ParseAmount(string input)
        {
            var ex = new Regex(@"\p{Sc}");
            var symbol = ex.Match(input).Value;

            input = input.Replace(symbol, "");

            decimal.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out var amount);

            return amount;
        }

        public static Currency ParseCurrency(string input)
        {
            var item = Currencies.FirstOrDefault(x => input.Contains(x.Value.Symbol));

            return item.Value;
        }
    }
}
