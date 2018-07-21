using System;

namespace ForDeleting
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int[] inputPermutation = new int[numbers.Length];
            for (int k = 0; k < n; k++)
            {
                inputPermutation[k] = int.Parse(numbers[k]);
            }
            int i = inputPermutation.Length - 1;//Започваме от последния индекс
            while (i > 0 && inputPermutation[i - 1] >= inputPermutation[i])
            {
                i--;
            }
            //i вече ни пази индекса на първия член на намалящата подредица отляво надясно (5, 3, 3, 0 i = i(5))
            if (i <= 0)
            {//Ако сме извървели цялата пермутация и не сме намерили края на нарастващата подредица, значи това е последната пермутация
                Console.WriteLine("This is the last permutation.");
                return;
            }
            //i-1 ни държи индекса на pivot-а
            int j = n - 1;
            while (inputPermutation[j] <= inputPermutation[i - 1])
            {
                j--;
            }//Разменяме Pivot-а с първото число от подредицата, което е по-голямо от него
            //Целта винаги е префикса където е i-1 да расте, a суфикса, където е j да намаля
            int swap = inputPermutation[j];
            inputPermutation[j] = inputPermutation[i - 1];
            inputPermutation[i - 1] = swap;
            //Остана да обърнем реда на елементите в суфикса
            j = n - 1;
            while (i < j)
            {
                swap = inputPermutation[i];
                inputPermutation[i] = inputPermutation[j];
                inputPermutation[j] = swap;
                i++;
                j--;
            }
            Console.WriteLine(string.Join(" ", inputPermutation));
            //Main();
        }
    }
}
