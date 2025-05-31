using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace метод_5
{
    internal class Program
    {
        public static List<int> RemoveDuplicates(List<int> numbers)
        {
            return new HashSet<int>(numbers).ToList();
        }

        public static void Main()
        {
            List<int> nums = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            List<int> unique = RemoveDuplicates(nums);
            Console.WriteLine(string.Join(", ", unique));
        }
    }
}
