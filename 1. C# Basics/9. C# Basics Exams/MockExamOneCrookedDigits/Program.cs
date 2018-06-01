using System;

namespace MockExamOneCrookedDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().Replace(".", "").Replace("-", "");
            while (number.Length > 1)
            {
                int result = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    result += (int)char.GetNumericValue(number[i]);
                }
                number = result.ToString();
            }
            Console.WriteLine(number);
        }
    }
}
