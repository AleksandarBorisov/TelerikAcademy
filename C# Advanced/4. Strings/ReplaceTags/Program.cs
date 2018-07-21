using System;

namespace ReplaceTags
{
    class Program
    {
        static void Main()
        {
            string documentHTML = Console.ReadLine();
            while (documentHTML.Contains("</a>"))
            {
                int startIndex = documentHTML.IndexOf("<a");
                int endIndex = documentHTML.IndexOf("</a>");
                string forCutting = documentHTML.Substring(startIndex, endIndex + 4 - startIndex);
                string text = forCutting.Substring(forCutting.IndexOf(">") + 1, forCutting.IndexOf("</a>") - (forCutting.IndexOf(">") + 1));
                string url = forCutting.Substring(forCutting.IndexOf("\"") + 1, forCutting.LastIndexOf("\"") - (forCutting.IndexOf("\"") + 1));
                documentHTML = documentHTML.Replace(forCutting, "[" + text + "]" + "(" + url + ")");
            }
            Console.WriteLine(documentHTML);
        }
    }
}
