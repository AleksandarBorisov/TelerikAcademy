using System;
using System.Numerics;

namespace BinaryFloatingPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = 340282346638528859811704183484516925440f;
            byte[] numberBits = BitConverter.GetBytes(number);//Прави битовете на числото на масив от 4 байта както са запаметени в паметта на компютъра
            //Console.WriteLine(string.Join(" ", numberBits));
            Console.WriteLine(Convert.ToString(BitConverter.ToInt32(numberBits, 0), 2).PadLeft(32, '0'));//Прави цяло число от масива от 4 байта и го извежда в двоична система


            string result = "";
            string[] floatPointNumber = Console.ReadLine().Split('.');
            string wholeNumberAsString = floatPointNumber[0];
            result += (wholeNumberAsString[0] == '-') ? "1 " : "0 ";//Започваме със знаковия бит
            BigInteger wholeNumber = BigInteger.Parse(wholeNumberAsString);//Взимаме цялата част от числото
            wholeNumber = BigInteger.Abs(wholeNumber);//И работим с абсолютната ѝ стойност
            float fractionNumber = float.Parse("0." + (floatPointNumber.Length > 1 ? floatPointNumber[1] : "0"));//Взимаме дробната част, като проверяваме дали има такава
            string numberInBinary = ConvertWholeNumber(wholeNumber) + ConvertFractionNumber(fractionNumber);//Съединяваме двете части, пребразувани в двоична система
            int startOfMantissa = 0;
            int exponent = -127;//Задаваме тази стойност, в случай че имаме дробна част 0 и for-цикъла отдолу няма да се изпълни до край
            if (wholeNumber > 1)
            {//Ако имаме цяла част то експонентата ще е броя цифри от първия символ до края на стринга, а мантисата ще започва от следващия елемент
                exponent = ConvertWholeNumber(wholeNumber).Length - 1;
                startOfMantissa = 1;
            }
            else
            {//Ако нямаме цяла част трябва да потърсим в стринга първата срещната единица
                for (int i = 0; i < numberInBinary.Length; i++)
                {
                    if (numberInBinary[i] == '1')
                    {
                        startOfMantissa = i + 1;//Започваме мантисата от следващия елемент, защото намерената единица вече се пази в паметта
                        exponent = -i;
                        break;//Всъщност тук броим позиции на местене на запетайката
                    }
                    else if (i == 126)//Щом сме прескочили горния if значи на 126 индекс нямаме '1', а мантисата неможе да започва след 126-тата цифра в двоична
                    {//т. е. ако до 126-тата цифра не сме намерили 1-ца тогава взимаме следващите 23 цифри, и експонентата ще бъде 0
                        startOfMantissa = i + 1;
                        exponent = -127;
                        break;
                    }
                }
            }
            string mantissa = numberInBinary.Substring(startOfMantissa, 23);
            result += ConvertWholeNumber(exponent + 127).PadLeft(8, '0') + " " + mantissa;
            Console.WriteLine(result);
        }

        static string ConvertWholeNumber(BigInteger wholeNumber)
        {
            string binaryWhole = "";
            do
            {
                int digit = (int)(wholeNumber % 2);
                wholeNumber /= 2;
                binaryWhole = digit + binaryWhole;
            } while (wholeNumber != 0);
            return binaryWhole;
        }

        static string ConvertFractionNumber(float fractionNumber)
        {
            string binaryFraction = "";
            if (fractionNumber == 0)
            {//Ако дробната част е 0 връщаме стринг от 0
                binaryFraction = new string('0', 23);
            }
            else
            {//Ако не е ще търсим първата единица
                bool startCounting = false;
                int counter = 0;
                do
                {
                    if (startCounting)
                    {
                        counter++;
                    }
                    fractionNumber *= 2;
                    int digit = (int)(fractionNumber);
                    if (fractionNumber >= 1)
                    {
                        digit = 1;
                        fractionNumber -= 1;
                        startCounting = true;//Започваме да броим 23 цифри след първата намерена единица
                    }
                    binaryFraction += digit;
                } while (counter < 23);
            }
            return binaryFraction;
        }
    }
}

//Оператор % между 1 и десетична дроб ни дава разликата между 1 и най-голямото цяло число умножено по дробта, даващо ни резултат
//по - малък от 1
//В тип float сумирайки всички възможни цифри от мантисата получаваме приемлива точност само до 7 знак след запетаята,
//след него всичко е грешно
