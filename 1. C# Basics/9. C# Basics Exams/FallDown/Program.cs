using System;

namespace FallDown
{
    class Program
    {
        static void Main()
        {
            byte[] numbers = new byte[8];
            for (sbyte col = 0; col < 8; col++)
            {
                numbers[col] = byte.Parse(Console.ReadLine());
            }
            //for (int i = 0; i < 8; i++)
            //{//Само за визуализирането
            //    Console.WriteLine(Convert.ToString(numbers[i], 2).PadLeft(8, '0'));
            //}
            //Console.WriteLine();
            for (sbyte bottom = 7; bottom >= 0; bottom--)
            {
                for (sbyte row = (sbyte)(bottom - 1); row >= 0; row--)
                {
                    byte oldBottom = numbers[bottom];
                    numbers[bottom] |= numbers[row];//Където има разминавания в 0 и 1 ги прехвърляме на долната цифра
                    numbers[row] &= oldBottom;//Където има разминавания в 0 и 1 ги изтриваме от горната цифра
                }
            }
            //for (int i = 0; i < 8; i++)
            //{//Само за визуализирането
            //    Console.WriteLine(Convert.ToString(numbers[i], 2).PadLeft(8,'0'));
            //}
            foreach (byte number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
