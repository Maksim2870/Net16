using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__4_from_the_15._07._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';
            while (again == 'y')
            {
                double total;
                Console.WriteLine("Введите число");
                var a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите символ вычисления");
                var oper = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите число");
                var b = Convert.ToDouble(Console.ReadLine());
                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine($"Сложение {a} и {b} равно {total}.");
                }
                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine($"Вычитание {a} и {b} равно {total}.");
                }
                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine($"Умножение {a} и {b} равно {total}.");
                }
                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine($"Деление {a} на {b} равно {total}.");
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите символ вычсления.");
                }
                Console.WriteLine("Продолжить / Закрыть? (y/n)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
