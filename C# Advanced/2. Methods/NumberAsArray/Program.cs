﻿using System;
using System.Text;

namespace NumberAsArray
{
    class Program
    {//В judge задачата се казва Big Numbers
        static void Main()
        {
            string sizes = Console.ReadLine();
            string firstString = Console.ReadLine().Replace(" ", "");
            string secondString = Console.ReadLine().Replace(" ", "");
            Console.WriteLine(Sum(firstString, secondString));
        }

        static string Sum(string firstString, string secondString)
        {
            StringBuilder sum = new StringBuilder();
            int countOneUp = 0;//Тук се пазят десетиците
            int units = 0;//Тук се пазят единиците
            int index = 0;
            while (index < firstString.Length || index < secondString.Length)
            {//Докато индекса е в гранците на поне единия от стринговете
                if (firstString.Length > secondString.Length && index >= secondString.Length)
                {//Ако втория масив е по-краткия и сме извън границите му
                    units = (firstString[index] - '0') + countOneUp;
                }
                else if (firstString.Length < secondString.Length && index >= firstString.Length)
                {//Ако първия масив е по-краткия и сме извън границите му
                    units = (secondString[index] - '0') + countOneUp;
                }
                else//Ако сме в границите и на двата стринга
                {
                    units = (firstString[index] - '0') + (secondString[index] - '0') + countOneUp;
                }
                sum.Append(units % 10).Append(" ");
                countOneUp = units / 10;
                index++;
            }
            if (countOneUp > 0)
            {
                return sum.Append(countOneUp).ToString();
            }
            return sum.Remove(sum.Length - 1, 1).ToString();
        }
    }
}
