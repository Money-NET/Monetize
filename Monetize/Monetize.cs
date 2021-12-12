using Monetize.Parsing;

namespace Monetize
{
    public static class Monetize
    {
        public static Money.Money Parse(string input)
        {
            var (amount, currency) = Parser.Parse(input);
            var money = new Money.Money(amount, currency);

            return money;
        }
    }
}
