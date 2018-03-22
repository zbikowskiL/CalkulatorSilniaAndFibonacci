using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalkulatorSilniaAndFibonacci
{
    public static class Silnia
    {
        public static double NormalCalculateSilnia(int x)
        {
            double result = 1;

            if (x <= 1)
            {
                result = 1;
            }
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }
            }
            return result;
        }

        public static double RekurentCalculateSilnia(int x)
        {
            {
                if (x <= 1)
                {
                    return 1;
                }
                else
                {
                    return x * RekurentCalculateSilnia(x - 1);
                } 
            }
        }
    }
}
