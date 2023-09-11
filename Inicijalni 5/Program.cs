using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;

            Console.WriteLine("Upišite link web stranice: ");
            a = Console.ReadLine();

            if(a.StartsWith("www.") && a.EndsWith(".hr"))
            {
                Console.WriteLine("Ovo je ispravni link u hrvatskom formatu.");
            }
            else
            {
                Console.WriteLine("Ovo nije ispravni link u hrvatskom formatu.");
            }

            Console.ReadKey();
        }
    }
}
