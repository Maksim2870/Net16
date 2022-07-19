using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._2_from_the_15._07._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A , B , C;
            double[] variables = new double[3];
            bool result = true;
            A = variables[0];
            B = variables[1];
            C = variables[2];
            Console.WriteLine();
            Console.WriteLine(
              "Выбирете одно из условий:" +
              "\nа) Только одно из чисел А и В четное;" +        
              "\nб) Только одно из чисел A и B и С меньше 50;" + 
              "\nв) Одно из чисел А и В положительное;" +       
              "\nг) Одно из чисел A, B, C отрицательное;" +     
              "\nд) Каждое из чисел А, В, С кратно трем;" +     
              "\nе) Каждое из чисел A, B, больше 100.");
            string s = Console.ReadLine();
            Console.WriteLine();

            switch (s)
            {
                case ("а"):
                    result = (A % 2 == 0) ^ (B % 2 == 0);
                    break;
                case ("б"):
                    result = (A < 50) ^ (B < 50) ^ (C < 50);
                    break;
                case ("в"):
                    result = (A > 0) & (B > 0);
                    break;
                case ("г"):
                    result = (A < 0) & (B < 0) & (C < 0);
                    break;
                case ("д"):
                    result = (A % 3 == 0) ^ (B % 3 == 0) ^ (C % 3 == 0);
                    break;
                case ("е"):
                    result = (A > 100) | (B > 100);
                    break;

                default:
                    {
                        Console.WriteLine("Неизвестное значение!");
                        break;
                    }
            }

        }

    }
}
