using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace метод_2
{
    internal class Program
    {
        public static bool IsPalindrome(string str)
        {
            str = str.ToLower().Replace(" ", "");
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    return false;
            }
            return true;
        }

        public static void Main()
        {
            Console.WriteLine(IsPalindrome("А роза упала на лапу Азора")); 
            Console.WriteLine(IsPalindrome("hello")); 
        }
    }
}