using System;

namespace _3.Cube
{
    class Program
    {
        static void Main()
        {
            int[,,] cube = {
                {
                    {1, 2, 3 },
                    {4, 5, 6 }
                },
                {
                    {7, 8, 9 },
                    {10, 11, 12 }
                }
            };
            for (int row = 0; row < cube.GetLength(0); row++)
            {
                Console.WriteLine("{");
                for (int col = 0; col < cube.GetLength(1); col++)
                {
                    Console.Write("   {");
                    for (int depth = 0; depth < cube.GetLength(2); depth++)
                    {
                        Console.Write("{0}, ", cube[row, col, depth]);
                    }
                    Console.WriteLine("}");
                }
                Console.WriteLine("}");
            }
        }
    }
}
