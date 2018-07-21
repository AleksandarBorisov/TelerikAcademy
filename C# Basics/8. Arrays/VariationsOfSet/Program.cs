using System;

namespace VariationsOfSet
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int variation;
            for (int i = 0; i < Math.Pow(n, k); i++)//Тъй като са вариации с повторение
            {
                variation = i;
                int[] currentVariation = new int[k];//Тук ни се пази настоящата вариация от k елемента
                for (int j = 0; j < k; j++)//За да разберем как се получават всички вариации трябва да си представим 
                {//бройна система с основа 10 и да направим аналогия с бройна система с основа 4 където сумата на произведението 
                 //на всеки елемент с 4( на степен реда на елемента от дясно наляво минус 1) и ще ни даде числото i
                    currentVariation[k - j - 1] = variation % n;//При това деление никога неможем да получим число по-голямо от n
                    variation = variation / n;//Запазваме елементите от дясно на ляво в масива
                }//Най-десния коефициент ни показва колко пъти се съдържа 4 на 0 степен, по-левия 4 на 1, следващия 4 на 2 и т.н.
                Console.Write("{0}{1}", '{', currentVariation[0] + 1);
                for (int j = 1; j < k; j++)
                {
                    Console.Write(", {0}", currentVariation[j] + 1);
                }
                Console.WriteLine("}");
            }
        }
    }
}
