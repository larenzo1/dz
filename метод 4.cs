using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace метод_4
{
    internal class Program
    {
        public static int FindMax(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                throw new ArgumentException("Список не может быть пустым");

            int max = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
                if (numbers[i] > max)
                    max = numbers[i];
            return max;
        }

        public static void Main()
        {
            List<int> nums = new List<int> { 3, 7, 2, 9, 1 };
            Console.WriteLine("Максимум: " + FindMax(nums));
        }
    }
}