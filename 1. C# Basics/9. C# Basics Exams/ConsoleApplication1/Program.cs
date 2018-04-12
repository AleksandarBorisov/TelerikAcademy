using System;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string numberAsString = Console.ReadLine();
            int position = 0;
            BigInteger bestProduct = 1;
            while (numberAsString != "END")
            {
                long number = long.Parse(numberAsString);
                if (position % 2 != 0)
                {
                    long productOfDigits = 1;
                    while (number > 0)
                    {
                        productOfDigits *= (number % 10 == 0 ? 1 : number % 10);
                        number /= 10;
                    }
                    bestProduct *= productOfDigits;
                }
                position++;
                if (position == 10)
                {
                    //position = 0;//Продължаваме да броим откъдето сме стигнали, не започваме отново
                    Console.WriteLine(bestProduct);
                    bestProduct = 1;
                }
                numberAsString = Console.ReadLine();
            }
            if (position != 10)//(position > 0)
            {
                Console.WriteLine(bestProduct);
            }
        }
    }
}
