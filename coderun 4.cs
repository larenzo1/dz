using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderun_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else if (n == 2)
            {
                Console.WriteLine(2);
            }
            else
            {
                int a = 1;
                int b = 1;
                int sum = a + b;

                for (int i = 3; i <= n; i++)
                {
                    int next = a + b;
                    sum += next;
                    a = b;
                    b = next;
                }

                Console.WriteLine(sum);
            }
        }
    }
}
