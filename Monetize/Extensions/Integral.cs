using Money;

namespace Monetize.Extensions
{
    public static class IntegralExtensions
    {
        public static Money.Money ToMoney(this int value, Currency currency)
        {
            return new Money.Money(value, currency);
        }

        public static Money.Money ToMoney(this uint value, Currency currency)
        {
            return new Money.Money((int)value, currency);
        }


        public static Money.Money ToMoney(this short value, Currency currency)
        {
            return new Money.Money(value, currency);
        }

        public static Money.Money ToMoney(this ushort value, Currency currency)
        {
            return new Money.Money(value, currency);
        }


        public static Money.Money ToMoney(this long value, Currency currency)
        {
            return new Money.Money(value, currency);
        }

        public static Money.Money ToMoney(this ulong value, Currency currency)
        {
            return new Money.Money(value, currency);
        }


#if NET || NET6_0
        public static Money.Money ToMoney(this nint value, Currency currency)
        {
            return new Money.Money(value, currency);
        }

        public static Money.Money ToMoney(this unint value, Currency currency)
        {
            return new Money.Money(value, currency);
        }
#endif
    }
}
