using System;

namespace _15._3DSlices
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            byte w = byte.Parse(input[0]);
            byte h = byte.Parse(input[1]);
            byte d = byte.Parse(input[2]);
            int[,][] numbers = new int[d, h][];
            for (int i = 0; i < h; i++)
            {
                input = Console.ReadLine().Split('|');
                for (int j = 0; j < input.Length; j++)
                {
                    numbers[i, j] = new int[w];
                    string[] currentArray = input[j].Trim().Split();
                    for (int m = 0; m < currentArray.Length; m++)
                    {
                        numbers[i, j][m] = int.Parse(currentArray[m]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
