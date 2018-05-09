using System;

namespace QuadronacciRectangle
{
    class Program
    {
        static void Main()
        {
            long q1 = long.Parse(Console.ReadLine());
            long q2 = long.Parse(Console.ReadLine());
            long q3 = long.Parse(Console.ReadLine());
            long q4 = long.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            Console.Write("{0} {1} {2} {3}", q1, q2, q3, q4);
            Console.Write(col > 4 ? " " : "\n");
            int lastToGenerate = row * col;
            for (int currentPosition = 5; currentPosition <= lastToGenerate; currentPosition++)
            {
                long q5 = q1 + q2 + q3 + q4;
                q1 = q2;
                q2 = q3;
                q3 = q4;
                q4 = q5;
                Console.Write("{0}", q5);
                Console.Write(currentPosition % col == 0 ? "\n" : " ");
            }
        }
    }
}
