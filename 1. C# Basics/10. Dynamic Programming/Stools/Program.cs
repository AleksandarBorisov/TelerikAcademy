using System;

namespace Stools
{
    class Program
    {
        static void Main()
        {//Като науча рекурсия да се върна на тази задача
            //Написах я, но алгоритъма е бавен и прави грешки
            int stoolsCount = int.Parse(Console.ReadLine());
            int[,] stools = new int[3, stoolsCount];
            for (int i = 0; i < stoolsCount; i++)
            {
                string[] currentStoolSize = Console.ReadLine().Split(' ');
                stools[0, i] = int.Parse(currentStoolSize[0]);
                stools[1, i] = int.Parse(currentStoolSize[1]);
                stools[2, i] = int.Parse(currentStoolSize[2]);
            }
            int firstIndex = 0;
            int secondIndex = 0;
            int thirdIndex = 0;
            int maxOfAll = 0;
            for (int i = (int)Math.Pow(3, stoolsCount) - 1; i >= 0; i--)
            {//Всички възможни случаи на избиране на една страна от всяка табуретка
                //От тези числа ще получим индекс за всяка колона, който ще ни бъде моментната избрана височина
                //Така всяка страна на всяка табуретка ще бъде височина точно по веднъж
                int currentIndex = i;
                int[,] areaDimensions = new int[3, stoolsCount];//Пазим избраните размери за съответното число тук
                for (int j = stoolsCount - 1; j >= 0; j--)
                {//Извървяваме един цял ред от дясно наляво, което ще ни е една комбинация
                    firstIndex = currentIndex % 3;//Индекса на височината
                    secondIndex = firstIndex + 1 >= 3 ? firstIndex + 1 - 3 : firstIndex + 1;//Иденксите на другите два координата
                    thirdIndex = firstIndex + 2 >= 3 ? firstIndex + 2 - 3 : firstIndex + 2;
                    currentIndex /= 3;
                    areaDimensions[0, j] = stools[firstIndex, j];//На първия ред от новия масив винаги пазим височината на табуретката
                    areaDimensions[1, j] = stools[secondIndex, j];//На следващите два реда пазим размерите на основата
                    areaDimensions[2, j] = stools[thirdIndex, j];//Това го правим основно за визуализация на комбинацията
                }
                for (int left = 0; left < stoolsCount; left++)
                {//Използваме SelectionSort, за да наредим табуретките по големината на размерите им във възходящ ред
                    //Като ориентир са ни и двата размера(от тук предполагам че идва и грешката)
                    for (int right = left + 1; right < stoolsCount; right++)
                    {
                        if (areaDimensions[1, right] < areaDimensions[1, left] && areaDimensions[2, right] < areaDimensions[2, left])
                        {
                            ExchangeValues(areaDimensions, 0, right, left);
                            ExchangeValues(areaDimensions, 1, right, left);
                            ExchangeValues(areaDimensions, 2, right, left);
                        }
                    }
                }
                int[] maxSubsequences = new int[stoolsCount];
                maxSubsequences[0] = areaDimensions[0, 0];
                //Иползвайки метода Longest Incresing Subsequence намираме максималната сума на нарастващата подредица
                //Проблема, който възниква е че няма как да сортираме идеално редица, използвайки два критерия, защото примерно ако сложим 50/20 в началото
                //После няма как да сложим 40/30 до него и то ще си остане някъде в средата на масива и от там се появяват и грешки
                for (int rightIndex = 1; rightIndex < stoolsCount; rightIndex++)
                {
                    for (int leftIndex = 0; leftIndex < rightIndex; leftIndex++)
                    {
                        if (areaDimensions[1, rightIndex] >= areaDimensions[1, leftIndex] && areaDimensions[2, rightIndex] >= areaDimensions[2, leftIndex])
                        {
                            maxSubsequences[rightIndex] = maxSubsequences[leftIndex] ;
                        }
                    }
                    maxSubsequences[rightIndex] += areaDimensions[0, rightIndex];
                    maxOfAll = Math.Max(maxOfAll, maxSubsequences[rightIndex]);//Търсим най-голямата възможна височина за съответната комбинация
                }
                maxOfAll = Math.Max(maxOfAll, maxSubsequences[0]);//Ако имаме само една табуретка, for циклите няма да се завъртят нито веднъж
            }
            Console.WriteLine(maxOfAll);
            //Main();
        }

        static void ExchangeValues(int[,] Array, int row, int colFirstIndex, int colSecondIndex)
        {
            int swap = Array[row, colFirstIndex];
            Array[row, colFirstIndex] = Array[row, colSecondIndex];
            Array[row, colSecondIndex] = swap;
        }
    }
}
