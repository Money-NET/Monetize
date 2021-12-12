using Money;
using Xunit;

namespace Monetize.Tests
{
    public class MonetizeTests
    {
        [Fact]
        public void ShouldDetectDollarAsCurrency()
        {
            var expected = new Money.Money(1.99, Currency.USD);
            var actual = Monetize.Parse("$1.99");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldDetectEuroAsCurrency()
        {
            var expected = new Money.Money(1.99, Currency.EUR);
            var actual = Monetize.Parse("€1.99");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldDetectPoundAsCurrency()
        {
            var expected = new Money.Money(1.99, Currency.GBP);
            var actual = Monetize.Parse("£1.99");

            Assert.Equal(expected, actual);


            //expected = new Money.Money(1.99, Currency.GBP);
            //actual = Monetize.Parse("₤1.99");

            //Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldDetectRealAsCurrency()
        {
            var expected = new Money.Money(1.99, Currency.BRL);
            var actual = Monetize.Parse("R$1.99");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldDetectRandAsCurrency()
        {
            var expected = new Money.Money(1.99, Currency.ZAR);
            var actual = Monetize.Parse("R1.99");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldDetectManatAsCurrency()
        {
            var expected = new Money.Money(1.99, Currency.AZN);
            var actual = Monetize.Parse("₼1.99");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldDetectYuanAsCurrency()
        {
            var expected = new Money.Money(1.99, Currency.CNY);
            var actual = Monetize.Parse("元1.99");

            Assert.Equal(expected, actual);
        }
    }
}
