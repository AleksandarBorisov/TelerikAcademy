using System;

namespace FiveSpecialLetters
{
    class Program
    {
        static void Main()
        {
            //Решение от мен без да ползваме методи

            long minWeight = long.Parse(Console.ReadLine());
            long maxWeight = long.Parse(Console.ReadLine());
            bool resultFound = false;
            for (char c1 = 'a'; c1 <= 'e'; c1++)
            {
                for (char c2 = 'a'; c2 <= 'e'; c2++)
                {
                    for (char c3 = 'a'; c3 <= 'e'; c3++)
                    {
                        for (char c4 = 'a'; c4 <= 'e'; c4++)
                        {
                            for (char c5 = 'a'; c5 <= 'e'; c5++)
                            {
                                string word = "" + c1 + c2 + c3 + c4 + c5;
                                long weight = 0;
                                int lastIndexUsed = 1;
                                bool[] isUsed = new bool[5];
                                for (int i = 0; i < word.Length; i++)
                                {
                                    if (isUsed[word[i] - 'a'] == false)
                                    {//word[i] ни е буква измежду a,b,c,d,e използвайки това получаваме индекс
                                        switch (word[i])
                                        {
                                            case 'a': weight += lastIndexUsed * 5; break;
                                            case 'b': weight += lastIndexUsed * -12; break;
                                            case 'c': weight += lastIndexUsed * 47; break;
                                            case 'd': weight += lastIndexUsed * 7; break;
                                            case 'e': weight += lastIndexUsed * -32; break;
                                        }
                                        isUsed[word[i] - 'a'] = true;
                                        lastIndexUsed++;
                                    }
                                }
                                if (minWeight <= weight && weight <= maxWeight)
                                {
                                    Console.Write(word + " ");
                                    resultFound = true;
                                }
                            }
                        }
                    }
                }
            }
            if (!resultFound)
            {
                Console.Write("No");
            }
            Console.WriteLine();
        }
    }
}
