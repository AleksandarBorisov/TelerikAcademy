using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HelloCSharp
    {
        static void Main(string[] args)
        {
            Console.Write("Каква е вашата възраст: ");
            DateTime age = DateTime.Parse(Console.ReadLine(MM.DD.YYYY));
            Console.WriteLine("Вашата възраст след 10 години ще бъде: "+(age+10));
        }
    }
}
