using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace метод_3
{
    internal class Program
    {
        public static int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Число должно быть неотрицательным");

            int result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        public static void Main()
        {
            Console.WriteLine(Factorial(5));
        }
    }
}