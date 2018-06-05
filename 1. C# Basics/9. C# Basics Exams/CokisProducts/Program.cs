using System;

namespace CokisProducts
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] products = new string[n];
            double[] prizeList = new double[n];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                int prizeProductDivider = 0;
                for (int j = line.Length - 1; j >= 0; j--)
                {//Четем отдясно наляво и намираме първия space
                    if (line[j] == ' ')
                    {
                        prizeProductDivider = j;
                        break;
                    }
                }
                prizeList[i] = double.Parse(line.Substring(prizeProductDivider + 1));//След него е индекса на цената на продукта
                products[i] = line.Substring(0, prizeProductDivider);//А преди него се намира самия продукт
            }
            int m = int.Parse(Console.ReadLine());//Броя листове с продукти
            double[] lists = new double[m];//Тук ще пазим сумите на всеки лист с продукти
            for (int i = 0; i < m; i++)
            {
                char symbol = ' ';
                while (symbol != '\n')//Това е последния символ на всеки ред
                {
                    symbol = (char)Console.Read();
                    int count = 0;
                    string product = "";
                    while (symbol != ',' && symbol != '\r')//Това е предпоследния символ на всеки ред
                    {
                        if (char.IsDigit(symbol))
                        {//Ако прочетения симвoл е число, записваме стойността му в count
                            count = count * 10 + (symbol - '0');
                        }
                        else
                        {//Ако прочетения символ е буква, записваме стойността му в product
                            product += symbol;
                        }
                        symbol = (char)Console.Read();
                    }
                    count = Math.Max(count, 1);//Ако не е упомената бройка на съответния артикул, взимаме бройка със стойност 1
                    lists[i] += count * prizeList[Array.IndexOf(products, product.Trim(' '))];//Добавяме на съответния индекс в масива lists
                    //Получения артикул търсим в масива products, и използваме намерения индекс, за да вземем цената от масива prizeList
                    symbol = (char)Console.Read();
                }
            }
            foreach (var list in lists)
            {
                Console.WriteLine("{0:F2}", list);
            }
        }
    }
}
