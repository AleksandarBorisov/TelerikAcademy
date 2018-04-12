using System;

namespace HiddenMessage
{
    class Program
    {
        static void Main()
        {
            string firstCommand = Console.ReadLine();
            string hiddenMessage = "";
            while (firstCommand != "end")
            {
                int indexStart = int.Parse(firstCommand);
                int nextNumbers = int.Parse(Console.ReadLine());
                string message = Console.ReadLine();
                if (indexStart < 0)
                {
                    indexStart += message.Length;//IndexStart е отрицателно число в този случай
                }
                while (indexStart >= 0 && indexStart < message.Length)
                {
                    hiddenMessage += message[indexStart];
                    indexStart += nextNumbers;//При положително надясно, а при отрицателно наляво
                }
                firstCommand = Console.ReadLine();
            }
            Console.WriteLine(hiddenMessage);
        }
    }
}
