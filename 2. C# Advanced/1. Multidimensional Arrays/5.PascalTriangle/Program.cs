using System;

namespace _5.PascalTriangle
{
    class Program
    {
        static void Main()
        {
            int height = 12;
            int[][] triangle = new int[height][];//Дефинираме назъбен масив
            for (int row = 0; row < triangle.Length; row++)//еквивалентно на col < height
            {
                triangle[row] = new int[row + 1];//Дефинираме всеки ред от назъбения масив
            }
            triangle[0][0] = 1;
            for (int row = 0; row < triangle.Length - 1; row++)
            {
                for (int col = 0; col < triangle[row].Length; col++)//еквивалентно на col <= row
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            for (int row = 0; row < triangle.Length; row++)
            {
                Console.Write("".PadLeft((height - row) * 2));
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    Console.Write("{0,4}", triangle[row][col]);
                }
                Console.WriteLine();
                //Console.WriteLine(String.Join(", ", triangle[row]));
            }
        }
    }
}
