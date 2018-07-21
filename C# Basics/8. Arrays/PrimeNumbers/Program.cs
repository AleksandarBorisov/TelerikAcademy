using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            bool[] isNotPrime = new bool[n + 1];//Стойностите на елементите, чиито индекси са числата от 2 до n
            for (int i = 2; i < Math.Sqrt(isNotPrime.Length); i++)
            {//Сложните числа в интервала от 2 до n са произведения на числата от 2 до корен от n
                //Няма смисъл да проверяваме с числа, по големи от корен от n, защото техните квадрати са по големи от n
                //и следователно немогат да бъдат произведения по малки от n
                if (!isNotPrime[i])//Всички булеви променливи имат стойност по подразбиране false
                {//Много важен if, за да не повтаряме вече отметнатите стойности
                    for (int j = i * i; j <= n; j += i)//Намираме всички числа, които се делят на i
                    {//Започваме от i * i, защото произведенията на i с по-малки числа вече са отбелязани
                        isNotPrime[j] = true;//Местата където имаме кратни на i се маркират като сложни числа
                    }
                }
            }
            //string result = "";
            //for (long i = 1; i <= n; i++)
            //{
            //    if (!isNotPrime[i])
            //    {
            //        result += i + " ";
            //    }
            //}
            //Console.WriteLine(result.Trim(' '));
            for (long i = n; i >= 0; i--)//Въртим ги отзад напред и търсим първото просто
            {
                if (!isNotPrime[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
