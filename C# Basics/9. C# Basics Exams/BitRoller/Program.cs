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
            int oneToRight = (freezeBitPos == 0 ? 18 : (freezeBitPos - 1));//Ако замразим нулевата позиция ще прехвърляме
            //единиците на 18 позиция, в противен случай ще ги прехвърляме на позицията отдясно на замразената
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
                if (((1 << freezeBitPos) & number) != 0)//Ако на замразената позиция е дошла 1
                {
                    if (bitFreeze == 0)
                    {//Проверяваме дали на замразената позиция не трябва да стои 0 и зануляваме
                        number &= ~(1 << freezeBitPos);
                    }
                    number |= (1 << oneToRight);//Прехвърляме единицата отдясно или най-отляво
                }
                number |= bitFreeze;//Ако на замразената позиция дойде стойност 0 винаги изпълняваме този оператор
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
