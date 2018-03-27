using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tal_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tal Pyramid");
            Console.WriteLine("Enter a number and then print the number's pryamid! (9)");

            string userInput = Console.ReadLine();
            int parsedInput = int.Parse(userInput);
            int[] multiplikationer = new int[10];
            for (int i = 1; i < 6; i++) // Loop 1
            {
                for (int j = 0; j < i; j++) // Loop 2
                {
                    Console.Write(99);
                }
                Console.WriteLine(); // Ny rad
            }

              foreach (int nummer in multiplikationer)
            Console.ReadLine();
        }
    }
}
