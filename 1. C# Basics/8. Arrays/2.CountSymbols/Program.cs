using System;

namespace _2.CountSymbols
{
    class Program
    {
        static void Main()
        {
            //Интересна задача, която намерих в нета
            string input = Console.ReadLine();
            int[] unicode = new int[127];
            for (int i = 0; i < input.Length; i++)
            {//input[i] е char който се каства към int и става индекс
                unicode[input[i]]++;
            }
            for (int i = 0; i < unicode.Length; i++)
            {
                if (unicode[i] != 0)
                {
                    Console.WriteLine("The letter {0} is used {1} time/s.", (char)i, unicode[i]);
                }
            }
        }
    }
}
