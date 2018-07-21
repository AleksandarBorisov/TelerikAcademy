using System;

namespace BitTime
{
    class Program
    {
        static void Main()
        {
            string inputNumber = Console.ReadLine();
            string outputNumber = Console.ReadLine();
            double[,] calculations = new double[inputNumber.Length + 1, outputNumber.Length + 1];
            //Защото празния стринг влиза в изчисленията добавяме 1 към размера на масива
            calculations[0, 0] = 0;
            //Запълваме първата колона
            for (int i = 1; i <= inputNumber.Length; i++)
            {
                calculations[i, 0] = calculations[i - 1, 0] + GetDeletionCost(inputNumber[i - 1]);
            }//За изтриване вземаме стойността отгоре и прибавяме настоящата
            //Запълваме първия ред
            for (int i = 1; i <= outputNumber.Length; i++)
            {
                calculations[0, i] = calculations[0, i - 1] + GetAdditionCost(outputNumber[i - 1]);
            }//За добавяне вземаме стойността отляво и прибавяме настоящата
            for (int i = 1; i <= inputNumber.Length; i++)
            {
                for (int j = 1; j <= outputNumber.Length; j++)
                {
                    double replaceCost = 0;//В случай че елементите са еднакви
                    if (inputNumber[i - 1] != outputNumber[j - 1])
                    {
                        replaceCost = 1;
                    }
                    replaceCost += calculations[i - 1, j - 1];//Добавяме диагоналната стойност
                    double addCost = GetAdditionCost(outputNumber[j - 1]);
                    addCost += calculations[i, j - 1];
                    double deleteCost = GetDeletionCost(inputNumber[i - 1]);
                    deleteCost += calculations[i - 1, j];
                    calculations[i, j] = Math.Min(Math.Min(addCost, deleteCost), replaceCost);
                }
            }
            Console.WriteLine(calculations[inputNumber.Length,outputNumber.Length]);
        }

        static double GetAdditionCost(char value)
        {
            if (value == '1')
            {
                return 1.2;//Цена за добавяне на 1
            }
            else
            {
                return 1.1;//Цена за добавяне на 0
            }
        }

        static double GetDeletionCost(char value)
        {
            if (value == '1')
            {
                return 0.8;//Цена за изтриване на 1
            }
            else
            {
                return 0.9;//Цена за изтриване на 0
            }
        }
    }
}
