using System;

namespace CrookedDigits
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine().Replace(".", "").Replace("-", "");
            while (number.Length > 1)
            {
                int result = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    result += number[i] - '0';
                }
                number = result.ToString();
            }
            Console.WriteLine(number);
        }
    }
}
