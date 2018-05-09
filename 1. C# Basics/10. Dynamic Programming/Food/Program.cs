using System;
using System.Collections.Generic;//За листовете ни трябва 

namespace Food
{
    public class Item
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public int Delight { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //Вариация на Knapsack problem
            int capacity = int.Parse(Console.ReadLine());
            int foodsCount = int.Parse(Console.ReadLine());
            List<Item> foods = new List<Item>();//Създаваме лист от обекти тип Item
            for (int i = 0; i < foodsCount; i++)
            {
                string[] food = Console.ReadLine().Split(' ');
                foods.Add(new Item
                {
                    Name = food[0],
                    Weight = int.Parse(food[1]),
                    Delight = int.Parse(food[2])
                });
            }
            int[,] bellySize = new int[foodsCount + 1, capacity + 1];
            int[,] backTracking = new int[foodsCount + 1, capacity + 1];

            for (int i = 1; i <= foodsCount; i++)
            {
                Item currentFood = foods[i - 1];//Защото листът от храни е нулево индексиран
                for (int j = 1; j <= capacity; j++)//j ни проверява всички възможни capacity-та
                {//При стойност 0 раницата неможе да побере нищо
                    int foodNotUsed = bellySize[i - 1, j];//Ако не се използва тази храна взимаме стойността на горната позиция
                    int foodUsed = 0;//Ако храната ще се използва
                    if (j - currentFood.Weight >= 0)
                    {//Проверяване дали има място за нея
                        foodUsed = bellySize[i - 1, j - currentFood.Weight] + currentFood.Delight;
                    }//Задаваме и стойност: нейната + ако има място за нещо друго
                    if (foodUsed >= foodNotUsed && foodUsed != 0)//За да не минаваме през всички 0 на връщане
                    {
                        bellySize[i, j] = foodUsed;
                        backTracking[i, j] = j - currentFood.Weight;//Т.е. пазим само колоната
                    }
                    else
                    {
                        bellySize[i, j] = foodNotUsed;
                    }
                }
            }
            int max = 0;
            int index = 0;
            for (int i = 1; i <= capacity; i++)
            {//Обхождаме само последния ред, защото там е максималната стойност
                if (bellySize[foodsCount, i] > max)
                {
                    max = bellySize[foodsCount, i];
                    index = i;
                }
            }
            Console.WriteLine(max);
            for (int i = foodsCount; i > 0; i--)//Вървим по вертикалата
            {
                if (bellySize[i, index] != bellySize[i - 1, index])//Ако настоящата стойност е различна от тази над нея
                {
                    Console.WriteLine(foods[i - 1].Name);//Индексите по вертикалата са точно индексите в листа - 1
                    index = backTracking[i, index];//Взимаме индекса на колоната на предшестващата я стойност
                }
            }
        }
    }
}
