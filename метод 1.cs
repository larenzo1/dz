using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace метод_1
{
    internal class Program
    {
        public static int SumList(List<int> numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static void Main()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма: " + SumList(nums)); 
        }
    }
}
