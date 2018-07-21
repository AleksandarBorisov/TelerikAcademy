using System;

namespace EnterNumbers
{
    class Program
    {
        static void Main()
        {
            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(ReadNumber(1, 100));
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Exception");
            }
        }

        static string ReadNumber(int start, int end)
        {
            int previousNumber = 1;
            string result = "1";
            for (int i = 1; i <= 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < start || number > end ||  previousNumber > number)
                {
                    throw new ArgumentOutOfRangeException();
                }
                result += " < " + number;
                previousNumber = number;
            }
            return result + " < 100";
        }
    }
}
