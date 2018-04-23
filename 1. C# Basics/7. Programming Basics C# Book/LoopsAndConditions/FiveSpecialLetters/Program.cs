using System;

namespace FiveSpecialLetters
{
    class Program
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            string pattern = "abcde";
            bool weightFound = false;
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        for (int p = 0; p < 5; p++)
                        {
                            for (int t = 0; t < 5; t++)
                            {//Друг вариант е без стринг да използваме ASCII  таблицата 'a'+ i ще ни даде a,b,c,d.... 
                                //string current = "" + (char)('a' + i) + (char)('a' + k) + (char)('a' + j) + (char)('a' + p) + (char)('a' + t);
                                string current = "" + pattern[i] + pattern[k] + pattern[j] + pattern[p] + pattern[t];
                                string unique = "" + current[0];
                                for (int l = 1; l < 5; l++)
                                {
                                    if (unique.IndexOf(current[l]) == -1)
                                    {
                                        unique += current[l];
                                    }
                                }
                                int sum = 0;
                                for (int l = 0; l < unique.Length; l++)
                                {
                                    int add = 0;
                                    switch (unique[l])
                                    {
                                        case 'a': add = 5; break;
                                        case 'b': add = -12; break;
                                        case 'c': add = 47; break;
                                        case 'd': add = 7; break;
                                        case 'e': add = -32; break;
                                    }
                                    sum += (l + 1) * add;
                                }
                                if (startNumber <= sum && sum <= endNumber)
                                {
                                    Console.Write(current + " ");
                                    weightFound = true;
                                }
                                current = "";
                                unique = "";
                            }
                        }
                    }
                }
            }
            if (!weightFound)
            {
                Console.Write("No");
            }
            Console.WriteLine();
        }
    }
}
