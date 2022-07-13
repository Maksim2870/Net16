using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Maksim";
            string surname = "Babich";
            int age = 42;
            int response = 0;
            while (response != -1)
            {
                Console.WriteLine("Enter 0 to enter your name" + Environment.NewLine +
                                  "Enter 1 to enter name" + Environment.NewLine +
                                  "Enter 2 to enter surname" + Environment.NewLine +
                                  "Enter 3 to enter age" + Environment.NewLine +
                                  "Enter -1 tp exit" + Environment.NewLine +
                                  "Enter -2 tp print exit");
                response = int.Parse(Console.ReadLine());
                switch (response)
                {


                    case -0:
                        {
                            Console.WriteLine("enter your name");
                            name = Console.ReadLine();
                            break;
                        }

                    case -1:
                        {

                            Console.WriteLine("enter name");
                            surname = Console.ReadLine();
                            break;
                        }

                    case -2:
                        {

                            Console.WriteLine("enter surname");
                            age = int.Parse(Console.ReadLine());
                            break;
                        }
                    case -3:
                        {

                            Console.WriteLine("enter age");
                            age = int.Parse(Console.ReadLine());
                            break;
                        }

                     default:
                        {
                            Console.WriteLine("You entered wrong number");
                            break;
                        }






                }
                
            }

        }
    }
}
