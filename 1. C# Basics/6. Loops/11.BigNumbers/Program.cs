using System;

namespace _11.BigNumbers
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            //Това решение е сравнително бавно, но работи (Този ред прави Run-time error при поставяне на задачата в judge!!!)
            //Затова гледай да го няма при други задачи
            int n = int.Parse(Console.ReadLine());
            string palindrom = Console.ReadLine().Replace(" ", "");
            string longestPalindrom = "";
            while (palindrom.Length > 2)
            {
                for (int backCounter = palindrom.Length - 1; backCounter > 0; backCounter--)
                {//Вътрешния цикъл ще върти от последния елемент до външния брояч
                    int left = 0;//Този брояч винаги започва от първия елемент
                    int right = backCounter;//Този брояч винаги започва откъдето е стигнал
                    string resultLeft = "";
                    string resultRight = "";
                    while (palindrom[left] == palindrom[right] && left <= right)
                    {//Този цикъл се върти докато срещоположните елементи са равни
                        if (left == right)
                        {//Индексите ще бъдат равни само при нечетна дължина на палиндрома и тогава трябва да вземем елемента само един път
                            resultLeft += palindrom[left];
                        }
                        else
                        {
                            resultLeft += palindrom[left];
                            resultRight = palindrom[right] + resultRight;
                        }
                        left++;
                        right--;
                    }
                    if (left > right && ((resultLeft + resultRight).Length > longestPalindrom.Length ||
                        ((resultLeft + resultRight).Length == longestPalindrom.Length && (resultLeft + resultRight).CompareTo(longestPalindrom) > 0)))
                        //Ако броячите са се кръстосали значи сме минали средата и двата крайни стринга се допират
                        //Проверяваме дали новия получен стринг е по-дълъг от предходния или дали е равен, но е лексикографски по-късно
                    {
                        longestPalindrom = resultLeft + resultRight;//Двата стринга стават новия най-дълъг палиндром
                        break;//Прекъсваме, защото щом са се събрали то този цикъл е изчерпан
                    }
                }
                palindrom = palindrom.Remove(0, 1).Trim('0');//Махаме първия елемент на началния стринг
            }
            Console.WriteLine(longestPalindrom.Trim('0'));
        }
    }
}
