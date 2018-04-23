using System;

namespace BintoDec
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int sum = 0;
            int power = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '1')
                {
                    power = number.Length - 1 - i;
                    sum += (int)Math.Pow(2, power);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
