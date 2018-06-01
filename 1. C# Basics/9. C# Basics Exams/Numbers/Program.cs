using System;

namespace Numbers
{
    class Program
    {
        static void Main()
        {
            string[] command = Console.ReadLine().Split(' ');
            string value = "";
            while (command[0] != "end")
            {
                if (command[0] == "set")
                {
                    value = command[1];
                }
                else if (command[0] == "front-add")
                {
                    value = command[1] + value;
                }
                else if (command[0] == "front-remove" && value != "")
                {
                    value = value.Remove(0, 1);
                }
                else if (command[0] == "back-add")
                {
                    value = value + command[1];
                }
                else if (command[0] == "back-remove" && value != "")
                {
                    value = value.Remove(value.Length - 1, 1);
                }
                else if (command[0] == "reverse")
                {
                    string reversed = "";
                    for (int i = value.Length - 1; i >= 0; i--)
                    {
                        reversed += value[i];
                    }
                    value = reversed;
                }
                else if (command[0] == "print")
                {
                    Console.WriteLine(value);
                }
                command = Console.ReadLine().Split(' ');
            }
        }
    }
}
