using System;

namespace JumpJump
{
    class Program
    {
        static void Main()
        {
            string instructions = Console.ReadLine();
            int position = 0;
            while (position >= 0 && position < instructions.Length)
            {
                if (instructions[position] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", position);
                    break;
                }
                else if ((instructions[position] - '0') == 0)
                {
                    Console.WriteLine("Too drunk to go on after {0}!", position);
                    break;
                }
                else if ((instructions[position] - '0') % 2 == 0)
                {
                    position += (instructions[position] - '0');
                }
                else if ((instructions[position] - '0') % 2 != 0)
                {
                    position -= (instructions[position] - '0');
                }
            }
            if (position < 0 || position >= instructions.Length)
            {
                Console.WriteLine("Fell off the dancefloor at {0}!", position);
            }
        }
    }
}
