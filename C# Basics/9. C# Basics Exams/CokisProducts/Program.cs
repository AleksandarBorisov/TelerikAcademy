using System;
using System.Text;

namespace CokisProducts
{
    class Program
    {
        static void Main()
        {
            //Достига се лимита от време, иначе логиката е вярна
            int n = int.Parse(Console.ReadLine());
            string[] products = new string[n];
            double[] prizeList = new double[n];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                int prizeProductDivider = line.LastIndexOf(' ');//Четем отдясно наляво и намираме първия space
                prizeList[i] = double.Parse(line.Substring(prizeProductDivider + 1));//След него е индекса на цената на продукта
                products[i] = line.Substring(0, prizeProductDivider).Trim(' ');//А преди него се намира самия продукт
            }
            int m = int.Parse(Console.ReadLine());//Броя листове с продукти
            double[] lists = new double[m];//Тук ще пазим сумите на всеки лист с продукти
            for (int i = 0; i < m; i++)
            {
                string[] lineRead = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < lineRead.Length; j++)
                {//Това решение е с предпоставката че никое име на продукт не започва с цифра или празно място
                    int count = 1;
                    lineRead[j] = lineRead[j].Trim(' ');//Ако започва със спейс елемента
                    StringBuilder product = new StringBuilder(lineRead[j]);
                    if (!char.IsLetter(product[0]))
                    {
                        int indexOfSpace = lineRead[j].IndexOf(' ');
                        count = int.Parse(product.ToString(0, indexOfSpace));
                        product.Remove(0, indexOfSpace + 1);
                    }
                    lists[i] += count * prizeList[Array.IndexOf(products, product.ToString().Trim(' '))];//Добавяме на съответния индекс в масива lists
                    //Получения артикул търсим в масива products, и използваме намерения индекс, за да вземем цената от масива prizeList
                }
            }
            foreach (var list in lists)
            {
                Console.WriteLine("{0:F2}", list);
            }
        }
    }
}
