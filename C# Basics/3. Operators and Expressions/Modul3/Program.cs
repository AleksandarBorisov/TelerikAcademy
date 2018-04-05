using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Option (1/2): ");
            var key = Console.ReadKey().KeyChar;
            switch (key)
            {
                case "1":
                    {
                        Console.Write("Моля въведете число: ");
                        int n = int.Parse(Console.ReadLine());
                        n = n % 2;
                        Console.WriteLine(n == 0 ? "Числото е четно" : "Числото е нечетно");
                    }
                case "2":
                    {
                        Console.Write("Моля въведете число: ");
                        int number = int.Parse(Console.ReadLine());
                        int remainderFive = number % 5;
                        int remainderSeven = number % 7;
                        Console.WriteLine(remainderFive == 0 && remainderSeven == 0 ? "Числото се дели без остатък" : "Числото не се дели без остатък");
                    }
            }
        }
    }
}
