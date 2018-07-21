using System;

namespace _5.Change
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            //int end = Math.Max(input[0].Length, input[1].Length);
            string result = "";
            bool plusTen = false;
            int differenceInLength = input[0].Length - input[1].Length;
            //Загатвам че платената сума винаги ще е повече от цената, за да имаме ресто
            for (int i = input[0].Length - 1; i >= 0; i--)
            {
                int minuend = input[0][i] - '0';//Умаляемо
                int subtrahend = 0;//Умалител
                if (i >= differenceInLength)
                {//Тъй като i се изменя отзад напред постепенно ще намаля докато не изчерпаме долния string
                    subtrahend = input[1][i - differenceInLength] - '0';
                }//Когато i стане по-малко от разликата значи сме изчерпали долния стринг и няма какво да четем от него повече
                if (plusTen)
                {//Ако в предходното изваждане сме взели 10, намаляме настоящата цифра
                    minuend--;
                    plusTen = false;
                }
                if (minuend - subtrahend < 0)
                {//Вземаме 10
                    minuend += 10;
                    plusTen = true;
                }
                result = minuend - subtrahend + result;
            }
            Console.WriteLine(result.TrimStart('0') == "" ? "0" : result.TrimStart('0'));
        }
    }
}
