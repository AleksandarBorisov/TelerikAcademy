using System;

namespace MixingNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < n-1; i++)
            //{
            //    Console.Write((numbers[i] % 10) * (numbers[i + 1] / 10)+" ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < n - 1; i++)
            //{
            //    Console.Write(Math.Abs(numbers[i]- numbers[i + 1]) + " ");
            //}
            //Console.WriteLine();
            int previousNumber = int.Parse(Console.ReadLine());
            string mixNumber = "";
            string subNumber = "";
            for (int i = 0; i < n - 1; i++)
            {
                int nextNumber = int.Parse(Console.ReadLine());
                mixNumber += string.Format("{0} ", (previousNumber % 10) * ((nextNumber / 10) % 10));
                subNumber += string.Format("{0} ", Math.Abs(previousNumber - nextNumber));
                previousNumber = nextNumber;
            }
            Console.WriteLine(mixNumber);
            Console.WriteLine(subNumber);
        }
    }
}
