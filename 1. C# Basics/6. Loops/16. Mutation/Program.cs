using System;

namespace _16.Mutation
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            string[] line = Console.ReadLine().Split(' ');
            for (int i = 0; i < line.Length; i++)
            {
                int numberBefMutation = int.Parse(line[i]);
                string newNumber = "";
                for (int j = 0; j < line[i].Length; j++)
                {
                    if (line[i][j] == '0')
                    {
                        newNumber += '9';
                    }
                    else if (line[i][j] == '9')
                    {
                        newNumber += '0';
                    }
                    else if ((line[i][j] - '0') % 2 == 0)
                    {
                        newNumber += (line[i][j] - '0' - 1);
                    }
                    else if ((line[i][j] - '0') % 2 != 0)
                    {
                        newNumber += (line[i][j] - '0' + 1);
                    }
                }
                int numberAfterMutation = int.Parse(newNumber);
                while (numberBefMutation != numberAfterMutation)
                {
                    if (numberBefMutation > numberAfterMutation)
                    {
                        numberBefMutation -= numberAfterMutation;
                    }
                    else
                    {
                        numberAfterMutation -= numberBefMutation;
                    }
                }
                if (numberBefMutation > 0 && numberBefMutation <= 9)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
