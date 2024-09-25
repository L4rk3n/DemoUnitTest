using DemoUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_XUnit
{
    public class DIvisionTest
    {
        [Fact]
        public void DivisionEntierValide()
        {
            Calcul c = new Calcul();
            double resultd = c.Division(6, 3);

            Assert.Equal(2, resultd);
        }

        [Fact]
        public void DivisionParZero()
        {
            Calcul c = new Calcul();
            Assert.Throws<DivideByZeroException>(
                () => c.Division(6, 0)
                );
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(10, 2, 5)]
        [InlineData(42, 7, 6)]
        public void DivisionMultipleValeur(int a, int b, double resultd)
        {
            Calcul c = new Calcul();
            Assert.Equal(resultd, c.Division(a, b));
        }
    }
}
