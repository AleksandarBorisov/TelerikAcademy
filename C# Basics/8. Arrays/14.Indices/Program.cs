using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftBracket = 0;
            int currentIndex = 0;
            Queue<int> sequence = new Queue<int>();
            StringBuilder result = new StringBuilder();
            bool[] visited = new bool[numbers.Length];
            while (currentIndex >= 0 && currentIndex < n && !visited[currentIndex])
            {
                visited[currentIndex] = true;
                sequence.Enqueue(currentIndex);
                currentIndex = numbers[currentIndex];
                leftBracket = currentIndex;
            }
            while(sequence.Count > 0)
            {
                if (leftBracket >= 0 && leftBracket < n && sequence.Peek() == leftBracket)
                {
                    result.Append("(");
                    result.Append(sequence.Dequeue());
                }
                else
                {
                    result.Append(" ");
                    result.Append(sequence.Dequeue());
                }
            }
            if (leftBracket >= 0 && leftBracket < n)
            {
                result.Append(')');
            }
            if (leftBracket != 0)
            {
                result.Remove(0, 1);
            }
            Console.WriteLine(result);
        }
    }
}
