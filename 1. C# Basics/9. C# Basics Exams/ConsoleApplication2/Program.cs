using System;
using System.Numerics;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            BigInteger evenProduct = 1;
            int counter = -1;
            string numberAsString = Console.ReadLine();
            while (numberAsString != "END")
            {
                BigInteger number = BigInteger.Parse(numberAsString);
                counter++;
                if (counter == 9)
                {
                    Console.WriteLine(evenProduct);
                    evenProduct = 1;
                    counter = 1;
                }
                else if (counter % 2 == 0)
                {
                    BigInteger even = number;
                    while (even != 0)
                    {
                        BigInteger digit = (even % 10) != 0 ? (even % 10) : 1;//Ако цифрата е 0 взимаме 1
                        evenProduct *= digit;
                        even /= 10;
                    }
                }
                numberAsString = Console.ReadLine();
            }
            Console.WriteLine(evenProduct);
        }
    }
}
