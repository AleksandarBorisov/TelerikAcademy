using System;

namespace HexToDec
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string number = Console.ReadLine();
                double end = number.Length;
                double dec = 1;
                double sum = 0;
                for (double i = 0; i < end; i++)
                {
                    char last = number[number.Length - 1];
                    switch (last)
                    {
                        case 'A': dec = 10 * Math.Pow(16, i); break;
                        case 'B': dec = 11 * Math.Pow(16, i); break;
                        case 'C': dec = 12 * Math.Pow(16, i); break;
                        case 'D': dec = 13 * Math.Pow(16, i); break;
                        case 'E': dec = 14 * Math.Pow(16, i); break;
                        case 'F': dec = 15 * Math.Pow(16, i); break;
                        default:
                            int digit = (int)char.GetNumericValue(last);
                            dec = digit * Math.Pow(16, i);
                            break;
                    }
                    number = number.Remove(number.Length - 1);
                    sum += dec;
                }
                Console.WriteLine("Числото в десетична система: " + sum);
                Console.WriteLine();
            }
        }
    }
}
