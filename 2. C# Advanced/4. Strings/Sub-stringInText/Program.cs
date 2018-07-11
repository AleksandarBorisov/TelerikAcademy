using System;

namespace Sub_stringInText
{
    class Program
    {
        static void Main()
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine().ToLower();
            int occurrences = 0;
            while (text.Contains(pattern))
            {
                int index = text.IndexOf(pattern);
                text = text.Remove(index, pattern.Length);
                occurrences++;
            }
            Console.WriteLine(occurrences);
        }
    }
}
