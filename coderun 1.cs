using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderun_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            long res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                res += Convert.ToInt64(nums[i]);
            }
            Console.WriteLine(res);
        }
    }
}
