using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace упр_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите первое число: ");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                if (number1 >= 0 && number1 <= 10 && number2 >= 0 && number2 <= 10)
                {
                    Console.WriteLine($"Результат умножения: {number1 * number2}");
                    break; 
                }
                else
                {
                    Console.WriteLine("Недопустимые числа! Пожалуйста, введите числа от 0 до 10.");
                }
            }
        }
    }
}

