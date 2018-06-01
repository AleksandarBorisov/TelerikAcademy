using System;

namespace _8.Dividers
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            bool primeDivisorFound = false;
            for (int i = 2; i <= Math.Min(m, n); i++)
            {
                bool isPrime = true;
                if ((m % i == 0) && (n % i == 0))
                {
                    for (int j = 2; j <= (int)Math.Sqrt(i); j++)//Проверяваме дали числото е просто
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.Write(i + " ");
                        primeDivisorFound = true;
                    }
                }
            }
            if (!primeDivisorFound)
            {
                Console.Write(-1);
            }
            Console.WriteLine();
        }
    }
}
