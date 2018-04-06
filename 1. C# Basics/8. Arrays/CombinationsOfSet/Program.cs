using System;

namespace CombinationsOfSet
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }
            for (int numbersInBits = 0; numbersInBits < (int)Math.Pow(2, n); numbersInBits++)
            {
                int bit = 0;
                string combination = "{";
                int counter = 0;
                for (int bitPosition = 0; bitPosition < n; bitPosition++)
                {
                    bit = (numbersInBits >> bitPosition) & 1;
                    if (bit == 1)
                    {
                        combination += numbers[bitPosition].ToString() + ", ";
                        counter++;
                    }
                }
                if (counter == k)
                {
                    Console.WriteLine(combination.Trim(' ', ',') + "}");
                }

            }
        }
    }
}
