using System;

namespace BitRoller
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int freezeBitPos = int.Parse(Console.ReadLine());
            int rollsCount = int.Parse(Console.ReadLine());
            int bitFreeze = (1 << freezeBitPos) & number;//Пази стойността и позицията на замразения бит
            //string binNumber = "";
            while (rollsCount > 0)
            {
                //Console.WriteLine(Convert.ToString(number, 2).PadLeft(19, '0'));
                //binNumber = Convert.ToString(number, 2).PadLeft(19, '0');
                //for (int i = 0; i <= 18; i++)//Само за визуализирането
                //{
                //    Console.Write(binNumber[i]);
                //    if (i % 4 == 2)
                //    {
                //        Console.Write(" ");
                //    }
                //}
                //Console.WriteLine();
                number &= ~(bitFreeze);//Зануляваме бита на замразената позиция
                int shiftedBit = number & 1;//Пазим най-десния бит, който ще изтрием
                number >>= 1;//Трием най-десния бит
                number |= (shiftedBit << 18);//Запазваме изтрития бит в новото число
                if ((bitFreeze & number) == 0)//Проверяваме дали на замразената позиция е дошла 0
                {
                    number |= bitFreeze;//Ако да присвояваме на тази позиция стойността на замразения бит
                }
                else//Ако обаче е дошла 1, изместваме тази 1 с една позиция надясно
                {
                    number |= (bitFreeze >> 1);//Това става лесно като просто присвоим 1 и на позицияа отдясно на замразената
                }
                rollsCount--;//Броим едно шифтване
            }
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(19, '0'));
            //binNumber = Convert.ToString(number, 2).PadLeft(19, '0');
            //for (int i = 0; i <= 18; i++)//Само за визуализирането
            //{
            //    Console.Write(binNumber[i]);
            //    if (i % 4 == 2)
            //    {
            //        Console.Write(" ");
            //    }
            //}
            //Console.WriteLine();
            Console.WriteLine(number);
        }
    }
}
