using System;

namespace BinaryShort
{
    class Program
    {
        static void Main()
        {
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2));//За сверяване

            string binary = "";
            if (number < 0)
            {
                binary = ConvertNegativeNumber(number);
                //Тук можем да минем и само с един метод като този ред ще изглежда  
                //binary = "1" + ConvertPositiveNumber((short)(number + 32768)).PadLeft(15,'0');
            }
            else
            {
                binary = ConvertPositiveNumber(number);
            }
            Console.WriteLine(binary);
            Main();
        }

        static string ConvertNegativeNumber(short number)
        {
            string binary = "";
            number = (short)((number + 1) * (-1));
            do
            {
                int digit = number % 2;
                number /= 2;
                binary = (1 - digit) + binary;
            } while (number != 0);//Принципа е същия като долу, само че добавяме противоположната цифра всеки път и накрая
            return binary.PadLeft(16, '1');//допълваме с единици
        }//Увеличаването на стойността на отрицателно число е равносилно на обратно броене с положителни числа

        static string ConvertPositiveNumber(short number)
        {
            string binary = "";
            do
            {
                int digit = number % 2;
                number /= 2;
                binary = digit + binary;
            } while (number != 0);
            return binary.PadLeft(16, '0');//binary;//Пишем това ако разкоментираме горе
        }
    }
}
