using System;

namespace _1.Challenge
{
    class Program
    {
        static void Main()
        {
            //Моето решение
            string message = "git is a <<version control>> system for tracking changes in <<computer files>> and coordinating work on those files among multiple people";
            string newString = "";
            bool upper = false;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == '<')
                {
                    upper = true;
                }
                else if (message[i] == '>')
                {
                    upper = false;
                }
                else if (upper)
                {
                    newString += char.ToUpper(message[i]);
                }
                else
                {
                    newString += message[i];
                }
            }
            Console.WriteLine(newString);

            //Решение от колега
            //var text = "git is a <<version control>> system for tracking changes in <<computer files>> and coordinating work on those files among multiple people";
            //while (text.Contains("<<"))
            //{
            //    int startIndex = text.IndexOf("<<");
            //    int endIndex = text.IndexOf(">>") + 2;
            //    int length = endIndex - startIndex;
            //    string substring = text.Substring(startIndex, length);
            //    string newSubstring = text.Substring(startIndex + 2, length - 4);
            //    text = text.Replace(substring, newSubstring.ToUpper());
            //}
            //Console.WriteLine(text);
        }
    }
}
