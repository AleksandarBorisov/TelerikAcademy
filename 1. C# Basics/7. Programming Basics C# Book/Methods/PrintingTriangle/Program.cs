using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //Принтиране на горна част на триъгълника
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }
            //Принтиране на долна част на триъгълника
            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
