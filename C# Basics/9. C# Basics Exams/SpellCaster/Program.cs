using System;

namespace SpellCaster
{
    class Program
    {
        static void Main()
        {
            string sentence = Console.ReadLine() + " ";
            string stepOneFinished = "";
            while (sentence != "")
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] == ' ')
                    {
                        if (sentence[i - 1] != ' ')
                        {
                            stepOneFinished += sentence[i - 1];
                            sentence = sentence.Remove(i - 1, 1);
                        }
                    }
                }
                sentence = sentence.TrimStart(' ');
            }
            string stepTwoFinished = stepOneFinished;
            int newPosition = 0;
            for (int i = 0; i < stepTwoFinished.Length; i++)
            {
                if (char.IsUpper(stepTwoFinished[i]))
                {
                    newPosition = (stepTwoFinished[i] - 'A' + 1 + i) % stepTwoFinished.Length;
                }
                else
                {
                    newPosition = (stepTwoFinished[i] - 'a' + 1 + i) % stepTwoFinished.Length;
                }
                string letter = stepTwoFinished[i] + "";
                stepTwoFinished = stepTwoFinished.Remove(i, 1);
                stepTwoFinished = stepTwoFinished.Insert(newPosition, letter);
            }
            Console.WriteLine(stepTwoFinished);
        }
    }
}
