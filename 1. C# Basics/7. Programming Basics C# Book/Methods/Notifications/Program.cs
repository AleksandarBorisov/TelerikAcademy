using System;

namespace Notifications
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ReadAndProcessMessage();
            }
        }
        static void ShowSuccessMessage(string operation, string message)
        {
            string firstMessage = "Successfully executed " + operation + ".";
            Console.WriteLine(firstMessage);
            Console.WriteLine(new string('=', firstMessage.Length));
            Console.WriteLine("{0}.", message);
            Console.WriteLine();
        }
        static void ShowWarningMessage(string message)
        {
            string firstMessage = "Warning: " + message + ".";
            Console.WriteLine(firstMessage);
            Console.WriteLine(new string('=', firstMessage.Length));
            Console.WriteLine();
        }
        static void ShowErrorMessage(string operation, string message, string errorCode)
        {
            string firstMessage = "Error: Failed to execute " + operation + ".";
            Console.WriteLine(firstMessage);
            Console.WriteLine(new string('=', firstMessage.Length));
            Console.WriteLine("Reason: {0}.", message);
            Console.WriteLine("Error code: {0}.", errorCode);
            Console.WriteLine();
        }
        static void ReadAndProcessMessage()
        {
            string readMessage = Console.ReadLine();
            if (readMessage == "success")
            {
                string operation = Console.ReadLine();
                string message = Console.ReadLine();
                ShowSuccessMessage(operation, message);
            }
            else if (readMessage == "warning")
            {
                string message = Console.ReadLine();
                ShowWarningMessage(message);
            }
            else if (readMessage == "error")
            {
                string operation = Console.ReadLine();
                string message = Console.ReadLine();
                string errorCode = Console.ReadLine();
                ShowErrorMessage(operation, message, errorCode);
            }
        }
    }
}
