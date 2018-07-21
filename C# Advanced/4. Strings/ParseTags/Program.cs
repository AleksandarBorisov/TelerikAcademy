using System;

namespace ParseTags
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            while (text.Contains("<upcase>"))
            {
                int startIndex = text.IndexOf("<upcase>");
                int endIndex = text.IndexOf("</upcase>");
                string forRemoving = text.Substring(startIndex, endIndex + 9 - startIndex);
                string upperCase = text.Substring(startIndex + 8, endIndex - (startIndex + 8)).ToUpper();
                text = text.Replace(forRemoving, upperCase);
            }
            Console.WriteLine(text);
        }
    }
}
