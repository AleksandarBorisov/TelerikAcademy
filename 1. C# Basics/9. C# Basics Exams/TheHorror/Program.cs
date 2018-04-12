using System;

namespace TheHorror
{
    class Program
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            int count = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += numbers[i] - '0';//Може и с char.GetNumericValue()
                    count++;
                }
            }
            Console.WriteLine("{0} {1}",count,sum);
        }
    }
}
