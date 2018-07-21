using System;

namespace CombinationsOfSet
{
    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int k = int.Parse(line[1]);
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }
            //Find the number of all possible combinations
            long faktorial = 1;
            long divisor = 1;
            for (long i = n; i >= n - k + 1; i--)
            {
                faktorial *= i;
                divisor *= n - i + 1;
            }
            long countOfCombinations = faktorial / divisor;
            int[] combinationCode = new int[countOfCombinations];
            //Find all numbers, which bits will represent the elements of the combination
            int index = 0;
            for (int bitMask = (int)Math.Pow(2, n) - 1; bitMask >= 0; bitMask--)
            {
                int counterOfOnes = 0;
                int numberCountingOnes = bitMask;
                //Count all bits that are 1s in each number
                while (numberCountingOnes != 0)
                {
                    numberCountingOnes = numberCountingOnes & (numberCountingOnes - 1);
                    counterOfOnes++;
                }
                if (counterOfOnes == k)
                {//Save all numbers, which bits are equal to K
                    combinationCode[index] = bitMask;
                    index++;
                }
            }
            //Print all elements wich lie on position with bit representation of 1 in the saved combinations 
            for (index = 0; index < combinationCode.Length; index++)
            {
                string combination = "";
                for (int bitPosition = 0; bitPosition < n; bitPosition++)
                {
                    int bit = 0;
                    bit = combinationCode[index] & (1 << n - bitPosition - 1);//Взимаме битовете отляво надясно
                    if (bit != 0)
                    {
                        combination += numbers[bitPosition].ToString() + " ";
                    }
                }
                Console.WriteLine(combination.Trim(' '));
            }
        }
    }
}
