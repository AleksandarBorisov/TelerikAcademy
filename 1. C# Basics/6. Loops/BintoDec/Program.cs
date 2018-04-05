using System;

namespace BintoDec
{
    class Program
    {
        static void Main()
        {
                string number = Console.ReadLine();
                string buffer = null;
                long end = (long)Math.Pow(2, number.Length);
                int move = (number.Length) - 1;
                long k;
                for (long i = 0; i < end; i++)
                {
                    for (long j = end / 2; j >= 1; j /= 2)
                    {
                        k = i & j;
                        k = k >> move;
                        if (k == 0)
                        {
                            buffer += 0;
                        }
                        else
                        {
                            buffer += 1;
                        }
                        move--;
                    }
                    if (number == buffer)
                    {
                        Console.WriteLine(i);
                    }
                    buffer = null;
                    move = (number.Length) - 1;
                }
        }
    }
}
