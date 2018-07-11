using System;

namespace ReverseSentence
{
    class Program
    {
        static void Main()
        {
            string[] sentence = Console.ReadLine().Split();
            string[] result = new string[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {//Проверяваме дали последния символ от всеки стринг е пунктуационен знак и го прибавяме на съответната позиция отдясно
                if (sentence[i][sentence[i].Length - 1] != '#' && char.IsPunctuation(sentence[i], sentence[i].Length - 1))
                {//Тъй като отчита #-а като пунктуационен знак
                    result[i] += sentence[i][sentence[i].Length - 1];
                    sentence[i] = sentence[i].Remove(sentence[i].Length - 1);//Изтриваме пунктуационния знак
                }
                result[sentence.Length - 1 - i] = sentence[i] + result[sentence.Length - 1 - i];
            }//Лепим думата отляво, за да пасне на знака на съответната позиция
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
