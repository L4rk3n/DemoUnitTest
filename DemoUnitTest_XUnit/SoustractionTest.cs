using DemoUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_XUnit
{
    public class SoustractionTest
    {
        [Fact]
        public void SoustractionEntierValide()
        {
            Calcul c = new Calcul();
            int result = c.Soustraction(5, 3);

            Assert.Equal(2, result);
        }

        [Fact]
        public void SoustractionValeurLimite()
        {
            Calcul c = new Calcul();
            Assert.Throws<OverflowException>(
                () => c.Soustraction(int.MinValue, 10)
                );
        }
        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(10, 5, 5)]
        [InlineData(25, 17, 8)]

        public void SoustractionMultipleValeur(int a, int b, int result)
        {
            Calcul c = new Calcul();
            Assert.Equal(result, c.Soustraction(a, b));
        }


    }
}
