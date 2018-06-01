using System;

namespace ExRugs
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int sizeX = int.Parse(Console.ReadLine());//Крайната дебелина на Х
            int widthX = sizeX / 2 + 1;//Моментната дебелина на X
            int rugWidth = 2 * size + 1;
            int middleDots = rugWidth - 2 - 2 * widthX;
            int sideDots = 0;
            //Upper upper half
            if (rugWidth >= (2 * (sizeX / 2 + 1) + 3))//Ако цялата ширина е по-голяма или равна на 
            {//броя '#' от двете страни + "\./" в средата влизаме в циклите
                for (int i = middleDots; i >= 1; i -= 2)//Точиците са ни показателя, ако остане 1 спираме
                {
                    if ((rugWidth == (i + 2 * widthX + 2)))
                    {//Все още widthX не е достигнала sizeX
                        Console.WriteLine("{0}\\{1}/{0}",
                        new string('#', widthX),
                        new string('.', i));
                    }
                    //Lower upper half
                    if (widthX < sizeX)
                    {
                        widthX++;
                    }
                    else if (rugWidth > (i + 2 * widthX + 2))//Проверяваме дали сумата точките + '\'+'/'+
                    //+ '#' е станала по малка от цялата ширина и ако е, допълваме с точки и '\' отляво и
                    {//отдясно
                        Console.WriteLine("{0}\\{1}\\{2}/{1}/{0}",
                        new string('.', sideDots),
                        new string('#', sizeX),
                        new string('.', i));
                        sideDots++;
                    }
                }
            }
            //Upper-middle border row
            if (rugWidth == (2 * widthX + 1))
            {
                Console.WriteLine("{0}X{0}",
                new string('#', widthX));
            }
            else if (rugWidth > (2 * widthX + 1))
            {
                Console.WriteLine("{0}\\{1}X{1}/{0}",
                new string('.', sideDots),
                new string('#', widthX));
            }
            //Upper middle half
            int middleStart = Math.Min(size, (sizeX - 1) / 2);//защото първо въртях от 2 * sizeX - 1 до sizeX
            //но след като sizeX ставаше по-голямо от 2 * size + 1 започваха проблеми, затова слагам това ограничение
            //така цикълът няма да се върти повече от size на брой пъти
            for (int i = middleStart; i >= 1; i--)//Докато i стане равно на '#' в средата
            {//приемаме че при i = 1 броя '#' в средата е равен на sizeX
                if (rugWidth <= sizeX + 2 * i)
                {
                    Console.WriteLine(new string('#', rugWidth));
                }
                else//rugWidtch > sizeX + 2 * i
                {
                    Console.WriteLine("{0}\\{1}/{0}",
                    new string('.', (rugWidth - (sizeX + 2 * i) - 2) / 2),
                    new string('#', sizeX + 2 * i));
                }
            }
            //Middle row
            if (rugWidth >= 2 + sizeX)
            {
                Console.WriteLine("{0}X{1}X{0}",
                new string('.', (rugWidth - 2 - sizeX) / 2),
                new string('#', sizeX));
            }
            else if (rugWidth < 2 + sizeX)
            {
                Console.WriteLine(new string('#', rugWidth));
            }
            //Lower middle half
            int middleEnd = Math.Min(size, (sizeX - 1) / 2);
            for (int i = 1; i <= middleEnd; i++)
            {
                if (rugWidth <= sizeX + 2 * i)
                {
                    Console.WriteLine(new string('#', rugWidth));
                }
                else//rugWidtch > sizeX + 2 * i
                {
                    Console.WriteLine("{0}/{1}\\{0}",
                    new string('.', (rugWidth - (sizeX + 2 * i) - 2) / 2),
                    new string('#', sizeX + 2 * i));
                }
            }
            //Lower-middle border row
            if (rugWidth == (2 * widthX + 1))
            {
                Console.WriteLine("{0}X{0}",
                new string('#', widthX));
                widthX--;
            }
            else if (rugWidth > (2 * widthX + 1))
            {
                Console.WriteLine("{0}/{1}X{1}\\{0}",
                new string('.', sideDots),
                new string('#', widthX));
            }
            //Upper lower half
            middleDots = rugWidth - 2 - 2 * (sizeX / 2 + 1);
            if (rugWidth >= (2 * (sizeX / 2 + 1) + 3))
            {
                for (int i = 1; i <= middleDots; i += 2)
                {
                    if ((rugWidth == (i + 2 * widthX + 2)))
                    {
                        Console.WriteLine("{0}/{1}\\{0}",
                        new string('#', widthX),
                        new string('.', i));
                        if (widthX > sizeX / 2 + 1)
                        {
                            widthX--;
                        }
                    }
                    //Lower lower half
                    else if (rugWidth > (i + 2 * widthX + 2))
                    {
                        sideDots--;
                        Console.WriteLine("{0}/{1}/{2}\\{1}\\{0}",
                        new string('.', sideDots),
                        new string('#', sizeX),
                        new string('.', i));
                    }
                }
            }
        }
    }
}
