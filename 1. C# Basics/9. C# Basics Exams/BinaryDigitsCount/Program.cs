using System;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main()
        {
            byte bit = byte.Parse(Console.ReadLine());
            short n = short.Parse(Console.ReadLine());
            string answer = "";
            for (int i = 0; i < n; i++)
            {
                uint number = uint.Parse(Console.ReadLine());
                int numberLength = Convert.ToString(number, 2).Length;
                int countOnes = 0;
                while (number != 0)
                {
                    number = number & (number - 1);
                    countOnes++;
                }
                if (bit == 1)
                {
                    answer += countOnes.ToString() + '\n';
                }
                else
                {
                    answer += (numberLength - countOnes).ToString() + '\n';
                }
            }
            Console.Write(answer);
        }
    }
}
