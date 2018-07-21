using System;

namespace HexToDec
{
    class Program
    {
        static void Main()
        {
            //while (true)
            //{
            string number = Console.ReadLine();
            long dec = 0;
            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case 'A': dec += 10 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case 'B': dec += 11 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case 'C': dec += 12 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case 'D': dec += 13 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case 'E': dec += 14 * (long)Math.Pow(16, number.Length - i - 1); break;
                    case 'F': dec += 15 * (long)Math.Pow(16, number.Length - i - 1); break;
                    default: dec += (int)char.GetNumericValue(number[i]) * (long)Math.Pow(16, number.Length - i - 1); break;
                }
            }
            Console.WriteLine(dec);
            //Console.WriteLine();
            //}
        }
    }
}
