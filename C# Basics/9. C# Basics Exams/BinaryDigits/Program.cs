using System;

namespace BinaryDigits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int row = 0; row <= 3; row++)
            {
                int position = 15;
                while (position >= 0)
                {
                    int bit = (number >> position) & 1;
                    if (bit == 1)
                    {
                        switch (row)
                        {
                            case 0: Console.Write(".#."); break;
                            case 1: Console.Write("##."); break;
                            case 2: Console.Write(".#."); break;
                            case 3: Console.Write("###"); break;
                        }
                    }
                    else
                    {
                        switch (row)
                        {
                            case 0: Console.Write("###"); break;
                            case 1: Console.Write("#.#"); break;
                            case 2: Console.Write("#.#"); break;
                            case 3: Console.Write("###"); break;
                        }
                    }
                    if (position != 0)
                    {
                        Console.Write(".");
                    }
                    position--;
                }
                Console.WriteLine();
            }
        }
    }
}
