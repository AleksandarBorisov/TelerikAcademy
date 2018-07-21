using System;

namespace MazeRunner
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string number = Console.ReadLine();
                int sumEven = 0;
                int sumOdd = 0;
                for (int j = 0; j < number.Length; j++)
                {
                    if ((number[j] - '0') % 2 == 0)
                    {
                        sumEven += number[j] - '0';
                    }
                    else
                    {
                        sumOdd += number[j] - '0';
                    }
                }
                if (sumEven == sumOdd)
                {
                    Console.WriteLine("straight");
                }
                else if (sumEven > sumOdd)
                {
                    Console.WriteLine("left");
                }
                else
                {
                    Console.WriteLine("right");
                }
            }
        }
    }
}
