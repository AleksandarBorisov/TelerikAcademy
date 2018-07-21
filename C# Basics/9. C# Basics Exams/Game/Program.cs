using System;

namespace Game
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int a = (n / 100) % 10;
            int b = (n / 10) % 10;
            int c = (n / 1) % 10;
            int max = 0;
            for (int i = 1; i <= 4; i++)
            {
                int result = 0;
                switch (i)
                {
                    case 1: result = a + b + c; break;
                    case 2: result = a * b + c; break;
                    case 3: result = a + b * c; break;
                    case 4: result = a * b * c; break;
                }
                max = Math.Max(max, result);
            }
            Console.WriteLine(max);
        }
    }
}
