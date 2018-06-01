using System;

namespace Legs
{
    class Program
    {
        static void Main(string[] args)
        {
            int legs = int.Parse(Console.ReadLine());
            int count = 0;
            //Това е моето решение, но е много бавно
            //for (int i = legs / 2; i >= 0; i--)
            //{
            //    for (int j = 0; j <= legs / 5; j++)
            //    {
            //        for (int k = 0; k <= legs / 7; k++)
            //        {
            //            if (i * 2 + j * 5 + k * 7 == legs)
            //            {
            //                count++;
            //                break;
            //            }
            //        }
            //    }
            //}

            //Оптимизирано решение
            for (int i = 0; i <= legs; i += 7)
            {//Броим през 7
                for (int j = i; j <= legs; j += 5)
                {//Към 7 последователно прибавяме 5
                    if ((legs - j) % 2 == 0)
                    {//Ако някой от остатъците се дели на 2 без остатък значи е сума от двойките и можем да го преброим като комбинация
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
