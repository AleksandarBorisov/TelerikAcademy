using System;

namespace NeuromMapping
{
    class Program
    {
        static void Main()
        {
            uint number = 0;
            //uint[] inputNumbers = new uint[32];//Само за визуализацията са необходими
            //uint[] newNumbers = new uint[32];
            //int index = 0;
            while (UInt32.TryParse(Console.ReadLine(), out number))
            {
                //inputNumbers[index] = number;
                uint newNumber = 0;
                bool oneFound = false;
                for (int position = 0; position < 32; position++)//Пази ни позицията на която трябва да сменим бита с 1
                {
                    uint bit = (number & 1);
                    if (bit == 0 && number != 0 && oneFound == true)
                    {
                        newNumber |= ((uint)1 << position);
                    }
                    else if (bit == 1)
                    {
                        oneFound = true;
                    }
                    number >>= 1;
                }
                //newNumbers[index] = newNumber;
                //index++;
                Console.WriteLine(newNumber);
            }
            //for (int i = 0; i < 32; i++)
            //{
            //    Console.WriteLine(Convert.ToString(inputNumbers[i], 2).Replace('0', '.').PadLeft(32, '.'));
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //for (int i = 0; i < 32; i++)
            //{
            //    Console.WriteLine(Convert.ToString(newNumbers[i], 2).Replace('0', '.').PadLeft(32, '.'));
            //}
        }
    }
}
