using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькулятор
{
    internal class калькулятор
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите операцию (+, -, *, /, %): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

            if (operation == '+')
                result = num1 + num2;
            else if (operation == '-')
                result = num1 - num2;
            else if (operation == '*')
                result = num1 * num2;
            else if (operation == '/')
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Деление на ноль!");
                    return;
                }
            }
            else if (operation == '%')
            {
                if (num2 != 0)
                    result = num1 % num2;
                else
                {
                    Console.WriteLine("Деление на ноль!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Неверная операция");
                return;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
