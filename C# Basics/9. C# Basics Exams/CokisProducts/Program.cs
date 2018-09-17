using System;
using System.Collections.Generic;
using System.Text;

namespace CokisProducts
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            Dictionary<string, double> productsPrices = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                int prizeProductDivider = line.LastIndexOf(' ');//Четем отдясно наляво и намираме първия space
                productsPrices.Add(line.Substring(0, prizeProductDivider).Trim(' '), double.Parse(line.Substring(prizeProductDivider + 1)));
                //                  Преди него се намира самия продукт               След него е индекса на цената на продукта
            }
            int m = int.Parse(Console.ReadLine());//Броя листове с продукти
            double[] lists = new double[m];//Тук ще пазим сумите на всеки лист с продукти
            for (int i = 0; i < m; i++)
            {
                string lineRead = Console.ReadLine();
                for (int j = 0; j < lineRead.Length; j++)
                {//Това решение е с предпоставката че никое име на продукт не започва с цифра или празно място
                    int start = j;
                    while (char.IsDigit(lineRead[j]))
                    {
                        j++;
                    }
                    int count = start == j ? 1 : int.Parse(lineRead.Substring(start, j - start + 1));
                    start = j;
                    while (j < lineRead.Length && lineRead[j] != ',')
                    {
                        j++;
                    }
                    j++;
                    lists[i] += count * productsPrices[lineRead.Substring(start, j - start - 1).Trim()];//Добавяме на съответния индекс в масива lists
                    //Получения артикул търсим в речника products, и използваме намерения ключ, за да вземем цената
                }
                result.Append($"{lists[i]:F2}" + Environment.NewLine);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
