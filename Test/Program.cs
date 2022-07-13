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
            int haight = 0;
            while (response != -1)
            {
                Console.WriteLine("Enter 0 to enter  name" + Environment.NewLine +
                                  "Enter 1 to enter surname" + Environment.NewLine +
                                  "Enter 2 to enter age" + Environment.NewLine +
                                  "Enter 3 to enter haight" + Environment.NewLine +
                                  "Enter -1 to enter exit");
                                  
                response = int.Parse(Console.ReadLine());
                switch (response)
                {


                    case 0:
                        {
                            Console.WriteLine("enter  name");
                            name = Console.ReadLine();
                            break;
                        }

                    case 1:
                        {

                            Console.WriteLine("enter surname");
                            surname = Console.ReadLine();
                            break;
                        }

                    case 2:
                        {

                            Console.WriteLine("enter age");
                            age = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("haight");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            age = int.Parse(Console.ReadLine());
                            break;
                        }
                    case -1:
                        {

                            Console.WriteLine("enter exit");
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
