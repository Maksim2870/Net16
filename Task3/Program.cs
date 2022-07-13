using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите растояние между столбами в м.: ");
            string postSpacingText = Console.ReadLine();
            Console.Write("Введите ширину столба в см.: ");
            string postWidthText = Console.ReadLine();
            Console.Write("Введите колличество столбов: ");
            string postCountText = Console.ReadLine();
            int postSpacing = int.Parse(postSpacingText);
            int postWidth = int.Parse(postWidthText);
            int postCount = int.Parse(postCountText);
            int result = (postCount-1) * postSpacing*100 + postWidth * (postCount - 2);
            Console.Write("Расстояние между столбами, без ширины первого и последнего столба: ");
            Console.Write(result);
        }
    }
}
