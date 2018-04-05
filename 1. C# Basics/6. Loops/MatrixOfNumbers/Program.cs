using System;

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Въведете N: ");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; (i <= n + counter) && (counter < n); i++)
            {
                if (i == (n+counter))
                {
                    Console.WriteLine(i+" ");
                    counter++;
                    i = counter;
                }
                else
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
