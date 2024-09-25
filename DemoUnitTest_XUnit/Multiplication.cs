using DemoUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_XUnit
{
    public class Multiplication
    {
        [Fact]
        public void MultiplicationEntierValide()
        {
            Calcul c = new Calcul();
            int result = c.Multiplication(2, 3);

            Assert.Equal(6, result);
        }

        [Fact]
        public void MultiplicationValeurLimite()
        {
            Calcul c = new Calcul();
            Assert.Throws<OverflowException>(
                () => c.Multiplication(int.MaxValue, 2)
                );
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(4, 5, 20)]
        [InlineData(7, 6, 42)]
        public void MultiplicationMultipleValeur(int a, int b, int result)
        {
            Calcul c = new Calcul();
            Assert.Equal(result, c.Multiplication(a, b));
        }
    }
}
