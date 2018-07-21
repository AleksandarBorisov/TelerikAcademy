using System;
using System.Text;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main()
        {
            byte bit = byte.Parse(Console.ReadLine());
            short n = short.Parse(Console.ReadLine());
            StringBuilder answer = new StringBuilder();
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
                    answer.Append(countOnes).Append('\n');
                }
                else
                {
                    answer.Append((numberLength - countOnes)).Append('\n');
                }
            }
            Console.Write($"{answer.ToString()}");
        }
    }
}
