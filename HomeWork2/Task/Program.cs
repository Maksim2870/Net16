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
            void factorial(int fact)
            {
                int h1 = fact;
                long h2 = 1;
                if (fact == 0)
                    Console.WriteLine(1);
                else
                {
                    for (int i = 1; i <= h1; i++)
                    {
                        h2 *= i;
                    }
                }
                Console.WriteLine(h2);
            }
            factorial(7); 
            }

        }
    }
 }
