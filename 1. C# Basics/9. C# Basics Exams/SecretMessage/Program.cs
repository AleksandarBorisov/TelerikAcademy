using System;

namespace SecretMessage
{
    class Program
    {
        static void Main()
        {
            string firstCommand = Console.ReadLine();
            string secretMessage = "";
            int rowCounter = 1;
            while (firstCommand != "end")
            {
                int startIndex = int.Parse(firstCommand);
                int endIndex = int.Parse(Console.ReadLine());
                string subtitle = Console.ReadLine();
                if (startIndex < 0)
                {
                    startIndex += subtitle.Length;
                }
                if (endIndex < 0)
                {
                    endIndex += subtitle.Length;
                }
                while (startIndex <= endIndex)
                {
                    secretMessage += subtitle[startIndex];
                    if (rowCounter % 2 == 0)
                    {
                        startIndex += 4;
                    }
                    else
                    {
                        startIndex += 3;
                    }
                }
                rowCounter++;
                firstCommand = Console.ReadLine();
            }
            Console.WriteLine(secretMessage);
        }
    }
}
