using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest


{
    public class Calcul
    {
        int result = 0;
        double resultd = 0;

        public int Addition(int nb1, int nb2)
        {
            checked
            {
                try
                {
                    result = nb1 + nb2;
                    return result;
                }
                catch {
                    throw new OverflowException("Limite d'entier dépassée");
                }
            }
            
        }
        public int Soustraction(int nb1, int nb2)
        {
            checked
            {
                try
                {
                    result = nb1 - nb2;
                    return result;
                }
                catch
                {
                    throw new OverflowException("Limite d'entier dépassée");
                }
            }
        }

        public int Multiplication(int nb1, int nb2)
        {
            checked
            {
                try
                {
                    result = nb1 * nb2;
                    return result;
                }
                catch
                {
                    throw new OverflowException("Limite d'entier dépassée");
                }
            }
        }

        public double Division(int nb1, int nb2)
        {
            if (nb2 == 0)
            {
                throw new DivideByZeroException("Division par zéro non autorisée");
            }

            checked
            {
                try
                {
                    resultd = nb1 / nb2;
                    return resultd;
                }
                catch
                {
                    throw new OverflowException("Limite d'entier dépassée");
                }
            }
        }

    }

}
