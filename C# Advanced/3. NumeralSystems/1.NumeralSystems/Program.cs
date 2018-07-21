using System;

namespace _1.NumeralSystems
{
    class Program
    {
        static int IntParse(string number)
        {
            int result = 0;
            foreach (char digit in number)
            {
                result = result * 10 + (digit - '0');
            }
            return result;
        }

        static int ConvertToDecimal(string number, int numeralBase)
        {
            int result = 0;
            foreach (char digit in number)
            {
                result = result * numeralBase + (digit - '0');//Пример умножаваме по 2 и прибавяме остатъка, т.е. вървим на обратно
            }
            return result;
        }

        static int ConvertFromHexToDec(string number)
        {
            int result = 0;
            foreach (char digit in number)
            {
                int digitValue;
                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0';
                }
                else
                {
                    digitValue = digit - 'A' + 10;
                }
                result = result * 16 + digitValue;//Направете аналогия с преобразуването на стринг в число в десетична
            }
            return result;
        }

        static string FromDecTo(int value, int numeralBase)
        {
            string result = "";
            do
            {
                int digit = value % numeralBase;
                value /= numeralBase;
                result = digit + result;//Делим на базата и остатъците ги пишем в резултата
            }
            while (value != 0);
            return result;
        }

        static string DecToHex(int value)
        {
            string result = "";
            string hexDigits = "0123456789ABCDEF";
            do
            {
                int digitValue = value % 16;
                char digit = hexDigits[digitValue];
                value /= 16;
                result = digit + result;//Делим на 16 и остатъците ги пишем в резултата
            }
            while (value != 0);
            return result;

        }

        static void Main()
        {
            string[] tests2 =
            {
                "1101",
                "11",
                "10",
                "1",
                "100",
                "1111"
            };

            string[] tests3 =
            {
                "1021",
                "2",
                "10",
                "11",
                "12",
                "20",
                "221"
            };

            string[] testsHex =
            {
                "312AB",
                "FE",
                "1A",
                "ABCDEF",
                "AA",
                "21",
                "1A"
            };

            //foreach (string test in testsHex)
            //{
            //    Console.WriteLine(ConvertFromHexToDec(test));
            //}

            //Console.WriteLine(FromDecTo(0, 2));
            //Console.WriteLine(DecToHex(2536));
            Console.WriteLine(BitConverter.IsLittleEndian);//Показва в какъв режим работи класа и как се съхраняват данните за текущата компютърна архитектура
            //В този случай(Little-Endian) байтовете се подреждат отляво надясно от най-младшия към най-старшия
            //Името произлиза от там че байтовете от ("little" end - малкия край) се запаметяват първи
            //Това представяне се използва при Intel x86 и Intel x64 микропроцесорните архитектури.
            //Това е типично за C# върху Intel процесор.
        }

    }
}
//Позиционна бройна система означава степенна бройна система.
//За да запомня преминаването от десетична в друга бройна система, без да го зазубрям, използвам следната логика:
//Как взимаме цифрите на число в десетична (386)? Делим на 10, при което местим десетичната запетая наляво (38,6).
//Дробната част(остатъкът) е цифрата на единиците. Делим пак на 10(3,8), този път дробната част е цифрата на десетиците.
//Делим още веднъж и получаваме цифрата на стотиците(0,3) в дробната част. Същата логика прилагаме с дробни числа(0,386)
//само че там умножаваме по 10 и остатъкът е от цялата част(3,86). Аналогично е за другите бройни системи, използвайки базата им.
//Обратно за да преминем в десетична бройна система спазваме следната логика:
//Умножаваме стойността на съответната позиция по основата на бройната система, в която сме, повдигната на
//степен позициятта на стойността отдясно наляво. След десетичната запетая спазваме същата логика с отрицателни степени.
//По-лесния вариант(схема на Хорнер) е да умножим стойността на позиция 0 отляво надясно(тя е остатък при последното деление, 
//но е и стойност на числото при предпоследното деление) по основата на бройната система, в която сме, и да прибавим стойността на позиция 1, 
//после пак умножаваме по основата и прибавяме стойността на следващата позиция и така до края получаваме числото в десетична.