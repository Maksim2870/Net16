using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)

            
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);
            if (isNumber)
            {
                Console.Write("Результат: ");
                Console.WriteLine(-number);
            }
            else
            {
                Console.WriteLine("Ввести нужно только число!");
            }
         }
                      
    }
}
