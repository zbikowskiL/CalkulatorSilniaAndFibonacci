using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalkulatorSilniaAndFibonacci
{
    public static class Fibonacci
    {
        public static int FibonacciNumber(int number)
        {
            if (number <= 0)
            {
                return 0;
            }
            if (number == 1 || number == 2)
            {
                return 1;
            }
            return FibonacciNumber(number - 1) + FibonacciNumber(number - 2);
        }
    }
}
