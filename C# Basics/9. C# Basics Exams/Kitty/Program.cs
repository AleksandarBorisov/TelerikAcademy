using System;

namespace Kitty
{
    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            int countOfJumps = 0;
            int startPosition = 0;
            int escapedDeadlocks = 0;
            int collectedFood = input[0] == '*' ? 1 : 0;
            int collectedSouls = input[0] == '@' ? 1 : 0;
            bool deadlocked = input[0] == 'x' ? true : false;
            input[0] = 'E';
            if (!deadlocked)
            {
                string[] moves = Console.ReadLine().Split();
                for (int i = 0; i < moves.Length; i++)
                {
                    countOfJumps++;
                    startPosition += int.Parse(moves[i]);
                    if (startPosition >= input.Length)
                    {
                        startPosition %= input.Length;
                    }
                    else if (startPosition < 0)
                    {
                        startPosition = (input.Length + (startPosition % input.Length)) % input.Length;//% деление запазва знака и пак намира остатъка
                    }
                    if (input[startPosition] == '@')
                    {
                        collectedSouls++;
                        input[startPosition] = 'E';
                    }
                    else if (input[startPosition] == '*')
                    {
                        collectedFood++;
                        input[startPosition] = 'E';
                    }
                    else if (input[startPosition] == 'x')
                    {
                        if (startPosition % 2 == 0)
                        {
                            if (collectedSouls == 0)
                            {
                                deadlocked = true;
                                break;
                            }
                            else
                            {
                                collectedSouls--;
                                escapedDeadlocks++;
                                input[startPosition] = '@';//Оставяме душа в клетката
                            }
                        }
                        else
                        {
                            if (collectedFood == 0)
                            {
                                deadlocked = true;
                                break;
                            }
                            else
                            {
                                collectedFood--;
                                escapedDeadlocks++;
                                input[startPosition] = '*';//Оставяме храна в клетката
                            }
                        }
                    }
                }
            }
            if (deadlocked)
            {
                Console.WriteLine($"You are deadlocked, you greedy kitty!\nJumps before deadlock: {countOfJumps}");
            }
            else
            {
                Console.WriteLine($"Coder souls collected: {collectedSouls}\nFood collected: {collectedFood}\nDeadlocks: {escapedDeadlocks}");
            }
        }
    }
}
