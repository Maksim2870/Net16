using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string number = Console.ReadLine();
            int end = int.Parse(number);
            int start = 1;
            int result = 1;
            int curr = start;

            while (curr <= end)

            {
                
                if (curr == end)
                {
                    Console.Write(curr + " = ");
                }
                else
                {
                    Console.Write(curr + " * ");
                }
                result = curr * result;
                curr = (curr + 1);
            }
            Console.WriteLine(result);
        }
    }
 }

