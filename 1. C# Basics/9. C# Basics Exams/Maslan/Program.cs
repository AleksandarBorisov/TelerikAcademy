using System;
using System.Numerics;

namespace Maslan
{
    class Program
    {
        static void Main()
        {
            string numberAsString = Console.ReadLine();
            BigInteger product = 1;
            int transformations = 0;
            while (numberAsString.Length > 1 && transformations < 10)
            {
                product = 1;
                while (numberAsString.Length > 1)
                {
                    numberAsString = numberAsString.Substring(0, numberAsString.Length - 1);
                    int sumAtOddPositions = 0;
                    for (int i = 1; i < numberAsString.Length; i += 2)
                    {
                        sumAtOddPositions += numberAsString[i] - '0';
                    }
                    product *= (sumAtOddPositions != 0 ? sumAtOddPositions : 1);//Тази проверка е необходима,
                }//защото, докато при четните позиции на нулевата винаги ще имаме число различно от 0,
                transformations++;//то тук започвайки от първата позиция, може да имаме сума равна на 0
                numberAsString = product.ToString();
            }
            if (transformations < 10)
            {
                Console.WriteLine(transformations);
            }
            Console.WriteLine(numberAsString);
        }
    }
}
