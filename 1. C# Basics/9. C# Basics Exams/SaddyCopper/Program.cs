using System;
using System.Numerics;

namespace SaddyCopper
{
    class Program
    {
        static void Main(string[] args)
        {
            //BigInteger number = BigInteger.Parse(Console.ReadLine());
            //int transformations = 0;
            //while (number / 10 != 0 && transformations < 10)//Проверяваме дали числото е двуцифрено
            //{
            //    BigInteger productOfEvenPositions = 1;
            //    while (number / 10 != 0)// може и while(number > 9)
            //    {
            //        number /= 10;
            //        int sumEvenPositions = 0;
            //        //int digits = number.ToString().Length;//Прави string от числото и ни връща дължината му в брой символи
            //        int digits = (int)Math.Floor(BigInteger.Log10(number) + 1);
            //        for (int i = 0; i < digits; i += 2)
            //        {
            //            sumEvenPositions += (int)((number / BigInteger.Pow(10, digits - 1 - i)) % 10);
            //        }//Това решение заема твърде много памет
            //        //for (int i = (int)BigInteger.Log10(number); i >= 0; i -= 2)
            //        //{//Math.Log10 ни връща степента на 10 на числото в double
            //        //    sumEvenPositions += (int)((number / BigInteger.Pow(10, i)) % 10);
            //        //}//Това решение заема твърде много памет
            //        //int digits = number == 0 ? 1 : (int)Math.Floor(Math.Log10(Math.Abs((double)number)) + 1);
            //        //За вземане на броя на цифрите на каквото и да е целочислено число
            //        productOfEvenPositions *= sumEvenPositions;
            //    }
            //    number = productOfEvenPositions;
            //    transformations++;
            //}
            //if (transformations != 10)
            //{
            //    Console.WriteLine(transformations);
            //}
            //Console.WriteLine(number);
            string strNumber = Console.ReadLine();
            int transformations = 0;
            while (strNumber.Length > 1 && transformations < 10)
            {
                BigInteger product = 1;
                while (strNumber.Length > 0)
                {
                    strNumber = strNumber.Substring(0, strNumber.Length - 1);//Премахваме най-крайната буква
                    //strNumber = strNumber.Remove(strNumber.Length - 1);
                    int sum = 0;
                    for (int i = 0; i < strNumber.Length; i += 2)
                    {
                        sum += (strNumber[i] - '0');
                    }
                    product *= (sum != 0 ? sum : 1);//Да пробвам в BGCoder да махна това и да сложа 1
                }//във while-а горе вместо 0 - Става, обаче задачата заема повече памет
                strNumber = product.ToString();
                transformations++;
            }
            if (transformations < 10)
            {
                Console.WriteLine(transformations);
            }
            Console.WriteLine(strNumber);
        }
    }
}
