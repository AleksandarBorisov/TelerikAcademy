using System;
using System.Numerics;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            BigInteger evenProduct = 1;
            BigInteger productOfTen = 1;
            int counter = 0;
            string numberAsString = Console.ReadLine();
            while (numberAsString != "END")
            {
                long number = long.Parse(numberAsString);
                if (counter == 10)
                {
                    productOfTen = evenProduct;
                    evenProduct = 1;
                }
                if (counter % 2 == 0)
                {
                    while (number != 0)
                    {
                        evenProduct *= (number % 10) != 0 ? (number % 10) : 1;//Ако цифрата е 0 взимаме 1
                        number /= 10;
                    }
                }
                counter++;
                numberAsString = Console.ReadLine();
            }
            if (counter > 10)
            {
                Console.WriteLine(productOfTen);
            }
            Console.WriteLine(evenProduct);
        }
    }
}
