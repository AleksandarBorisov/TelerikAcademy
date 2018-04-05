using System;

namespace PrintADeck
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string face = Console.ReadLine();
                int n;
                string sign = "JQKA";
                bool parseSuccess = Int32.TryParse(face ,out n);
                for (int i = 2; i < 14; i++)
                {
                    if (i <= 10)
                    {
                        Console.Write(i + " of spades, ");
                        Console.Write(i + " of clubs, ");
                        Console.Write(i + " of hearts, ");
                        Console.Write(i + " of diamonds ");
                        Console.WriteLine();
                        if (i == n)
                        {
                            break;
                        }
                    }
                }
                if (!parseSuccess)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        Console.Write(sign[i]+ " of spades, ");
                        Console.Write(sign[i] + " of clubs, ");
                        Console.Write(sign[i] + " of hearts, ");
                        Console.Write(sign[i] + " of diamonds ");
                        Console.WriteLine();
                        if (sign[i]==face[0])
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
