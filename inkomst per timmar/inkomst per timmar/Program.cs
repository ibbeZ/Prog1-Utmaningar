using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkomst_per_timme
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ange ditt namn: ");
            string namn = Console.ReadLine();
            Console.Write("Ange din inkomst: ");
            int inkomst = int.Parse(Console.ReadLine());
            Console.Write("Ange antal timmar: ");
            int timmar = int.Parse(Console.ReadLine());

            Console.WriteLine("Din timme lön blev: " + (inkomst / timmar) + " k?r/h");
        }
    }
}
