using System;

namespace LeastMajorityMultiple
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            for (int i = c; i <= a * b * c; i++)
            {
                int divisionCount = 0;
                if (i % a == 0)
                {
                    divisionCount++;
                }
                if (i % b == 0)
                {
                    divisionCount++;
                }
                if (i % c == 0)
                {
                    divisionCount++;
                }
                if (i % d == 0)
                {
                    divisionCount++;
                }
                if (i % e == 0)
                {
                    divisionCount++;
                }
                if (divisionCount >= 3)
                {
                    Console.WriteLine(i);
                    break;  
                }
            }
        }
    }
}
