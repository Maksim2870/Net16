﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3
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
            {
                Console.Write(a + ", ");
                a++;
            }
               while ( a <= b; a = a + 1);

        }
    }
