using Money;

namespace Monetize.Extensions
{
    public static class FloatingExtensions
    {
        public static Money.Money ToMoney(this decimal value, Currency currency)
        {
            return new Money.Money(value, currency);
        }

        public static Money.Money ToMoney(this double value, Currency currency)
        {
            return new Money.Money(value, currency);
        }

        public static Money.Money ToMoney(this float value, Currency currency)
        {
            return new Money.Money(value, currency);
        }
    }
}
