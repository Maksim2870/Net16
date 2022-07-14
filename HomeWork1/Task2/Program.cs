using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            string aText = Console.ReadLine();
            Console.Write("Введите второе число: ");
            String bText = Console.ReadLine();
            int a = int.Parse(aText);
            int b = int.Parse(bText);
            for (; a <= b; a = a + 1) 
            {
                Console.Write(a + ", ");
            }

        }
           
            
            
        
    }
}






//  int  c = int. Parse(Console.ReadLine ());
//  int k = 2;
//  int a = 10000;
//  int b = 50;
//  int  sum = c;
//  sum = a + b - (2*b);
//  Console.WriteLine(c);
