using System;

namespace Cube_3D
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char whiteSpace = ' ';
            char edges = ':';
            char side = '|';
            char bottom = '-';
            int fill = n - 2;
            int sideCount = 0;
            int whiteSpaceCount = 1;
            Console.WriteLine(new string(edges, n));
            for (int i = 0; i < fill; i++)
            {
                Console.WriteLine(":{0}:{1}:",
                    new string(whiteSpace, fill),
                    new string(side, sideCount));
                sideCount++;
            }
            Console.WriteLine("{0}{1}:",
                new string(edges, n),
                new string(side, sideCount));
            for (int i = 0; i < fill; i++)
            {
                sideCount--;
                Console.WriteLine("{0}:{1}:{2}:",
                    new string(whiteSpace, whiteSpaceCount),
                    new string(bottom, fill),
                    new string(side, sideCount));
                whiteSpaceCount++;
            }
            Console.WriteLine("{0}{1}",
                new string(whiteSpace, whiteSpaceCount),
                new string(edges, n));

            //Решение, което никога не трябва да използвам, а е просто информативно
            //for (int i = 0; i < n; i++)
            //{//loop for cube outline
            //    //upper horizontal side
            //    Console.SetCursorPosition(i, 0);
            //    Console.Write(edges);

            //    //bottom horizontal side
            //    Console.SetCursorPosition(i, n - 1);
            //    Console.Write(edges);

            //    //left vertical side
            //    Console.SetCursorPosition(0, i);
            //    Console.Write(edges);

            //    //right vertical side
            //    Console.SetCursorPosition(n - 1, i);
            //    Console.Write(edges);

            //    //bottom horizontal side
            //    Console.SetCursorPosition(i + n - 1, 2 * (n - 1));
            //    Console.Write(edges);

            //    //bottom right vertical side
            //    Console.SetCursorPosition(2 * (n - 1), i + n - 1);
            //    Console.Write(edges);

            //    //top right diagonal side
            //    Console.SetCursorPosition(i + n - 1, i);
            //    Console.Write(edges);

            //    //bottom right diagonal side
            //    Console.SetCursorPosition(i + n - 1, i + n - 1);
            //    Console.Write(edges);

            //    //bottom left diagonal side
            //    Console.SetCursorPosition(i, n - 1 + i);
            //    Console.Write(edges);
            //}
            //for (int i = 2; i < n; i++)//С този цикъл минаваме на следващия диагонал
            //{//side
            //    for (int j = 0; j < n - 2; j++)//Този цикъл ни рисува всички | под най-горния диагинал
            //    {
            //        Console.SetCursorPosition(n + j, i + j);//n и i са ни нчалните координати на първия вертикал
            //        Console.Write(side);//прибавяйки j минаваме на следващия вертикал
            //    }
            //    //bottom
            //    for (int j = 0; j < n - 2; j++)
            //    {
            //        Console.SetCursorPosition(i + j, n + j);//(x,y)
            //        Console.Write(bottom);
            //    }
            //}
            //Console.SetCursorPosition(20, 20);
            //Console.WriteLine();

            ////Решение с масиви - по-бавно от метода със стрингове
            //char[,] cube = new char[2 * n - 1, 2 * n - 1];
            ////loop for cube outline
            //for (int i = 0; i < n; i++)
            //{//upper horizontal side
            //    cube[0, i] = edges;
            //    //bottom horizontal side
            //    cube[n - 1, i] = edges;
            //    //left vertical side
            //    cube[i, 0] = edges;
            //    //right vertical side
            //    cube[i, n - 1] = edges;
            //    //bottom horizontal side
            //    cube[2 * (n - 1), i + n - 1] = edges;
            //    //bottom right vertical side
            //    cube[i + n - 1, 2 * (n - 1)] = edges;
            //    //top right diagonal side
            //    cube[i, i + n - 1] = edges;
            //    //bottom right diagonal side
            //    cube[i + n - 1, i + n - 1] = edges;
            //    //bottom left diagonal side
            //    cube[n - 1 + i, i] = edges;
            //}
            //for (int i = 2; i < n; i++)
            //{//side
            //    for (int j = 0; j < n - 2; j++)
            //    {
            //        cube[i + j, n + j] = side;
            //    }
            //    //bottom
            //    for (int j = 0; j < n - 2; j++)
            //    {
            //        cube[n + j, i + j] = bottom;
            //    }
            //}
            //for (int row = 0; row < 2 * n - 1; row++)
            //{
            //    for (int col = 0; col < 2 * n - 1; col++)
            //    {
            //        if (cube[row, col] != 0)
            //        {
            //            Console.Write(cube[row, col]);
            //        }
            //        else
            //        {
            //            Console.Write(whiteSpace);
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}