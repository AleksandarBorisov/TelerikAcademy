using System;

namespace _4.GameWithNumbers
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int number = int.Parse(line[1]);
            string winners = null;
            int maxCommonDivisors = 0;
            line = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                int commonDivisors = 0;
                int nextNumber = int.Parse(line[i]);
                for (int j = number; j >= 2; j--)
                {//Намираме общите делители на даденото и следващото число
                    if (number % j == 0 && nextNumber % j == 0)
                    {
                        commonDivisors++;
                        if (commonDivisors > maxCommonDivisors)
                        {
                            maxCommonDivisors = commonDivisors;
                            winners = i + 1 + " ";
                        }
                        else if (commonDivisors == maxCommonDivisors)
                        {
                            winners += i + 1 + " ";
                        }
                    }
                }
            }
            if (maxCommonDivisors > 0)
            {
                Console.WriteLine(maxCommonDivisors);
            }
            Console.WriteLine(winners ?? "No winners");
        }
    }
}
