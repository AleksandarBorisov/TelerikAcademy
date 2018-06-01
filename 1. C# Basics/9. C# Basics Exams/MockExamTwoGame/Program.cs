using System;

namespace MockExamTwoGame
{
    class Program
    {
        static void Main()
        {
            int a = Console.Read() - '0';
            int b = Console.Read() - '0';
            int c = Console.Read() - '0';
            int max = 0;
            max = Math.Max(max, a + b + c);
            max = Math.Max(max, a * b + c);
            max = Math.Max(max, a + b * c);
            max = Math.Max(max, a * b * c);
            Console.WriteLine(max);
        }
    }
}
