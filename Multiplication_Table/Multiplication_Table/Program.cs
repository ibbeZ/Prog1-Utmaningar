using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication table");
            Console.WriteLine("Enter a number and then print the number's multiplication table.");
            string userInput = Console.ReadLine();
            int parsedInput = int.Parse(userInput);
            int[] multiplikationer = new int[10];
            for (int i = 0; i < 10; i++)
            {
                multiplikationer[i] = (i + 1) * parsedInput;
            }
            Console.WriteLine("that's your number multiplication table, it's right! yeah!:");
            foreach (int nummer in multiplikationer)
            {
                Console.WriteLine(nummer);
            }
            Console.ReadLine();
        }
    }
}