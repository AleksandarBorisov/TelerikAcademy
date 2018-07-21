using System;

namespace NthDigit
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            int numberAtIndex = FindNthDigit(number, index);
            Console.WriteLine(numberAtIndex);
        }
        static int FindNthDigit(int number, int index)
        {
            int counter = 1;
            if (number == 0)
            {
                return 0;
            }
            else
            {
                while (number != 0)
                {
                    if (counter == index)
                    {
                        return number % 10;
                    }
                    number /= 10;
                    counter++;
                }
            }
            return -1;
        }
    }
}
