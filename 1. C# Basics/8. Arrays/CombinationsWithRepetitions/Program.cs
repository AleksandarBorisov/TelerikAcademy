using System;

namespace CombinationsWithRepetitions
{
    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int k = int.Parse(line[1]);
            int[] combinations = new int[k];
            for (int j = 0; j < k; j++)
            {
                combinations[j] = 1;
            }//Първоначалните стойности са '1'
            int counter = k - 1;//Показва ни стойността на кой индекс увеличаваме
            Console.WriteLine(String.Join(" ", combinations));
            while (k > 1)
            {
                combinations[counter]++;
                while (counter < k - 1)
                {//Докато индекса е по-малък от последния, изравняваме стойностите който стоят на индексите отдясно на разглеждания
                    counter++;
                    combinations[counter] = combinations[counter - 1];
                }
                Console.WriteLine(String.Join(" ", combinations));
                while (combinations[counter] <= n - 1)
                {//Докато стойността на настоящия индекс е по-малка от максималната
                    combinations[counter]++;
                    Console.WriteLine(String.Join(" ", combinations));
                }
                while (combinations[counter] == n)
                {//Докато стойността на настоящия индекс е равна на максималната местим индекса наляво
                    counter--;
                    if (counter < 0)
                    {//Ако излезнем от масива, сме получили последната комбинация
                        return;
                    }
                }
            }
        }
    }
}
