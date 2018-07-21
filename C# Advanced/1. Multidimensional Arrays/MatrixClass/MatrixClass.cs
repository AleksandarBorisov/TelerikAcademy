using System;

namespace MatrixClass
{
    class MatrixClass
    {
        static void Main()
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOFColumns = int.Parse(Console.ReadLine());

            //matrix1 е обект от класа Matrix
            Matrix firstMatrix = new Matrix(numberOfRows, numberOFColumns);//По този начин заделяме обект в паметта
            firstMatrix.FillMatrix();
            Matrix secondMatrix = new Matrix(numberOfRows, numberOFColumns);
            secondMatrix.FillMatrix();
            Matrix sum = firstMatrix + secondMatrix;
            Console.WriteLine(sum.ToString());
            Matrix division = firstMatrix - secondMatrix;
            Console.WriteLine(division.ToString());
            Matrix multiplication = firstMatrix * secondMatrix;
            Console.WriteLine(multiplication.ToString());
        }
    }
}
