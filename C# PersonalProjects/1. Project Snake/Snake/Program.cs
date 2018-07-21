using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    struct Position
    {//Важно да се знае за структурите е че неможем да сравняваме директно техните елементи, а трябва да сравним поотделно всяко 
        public int row;//тяхно свойство
        public int col;
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }


    class Program
    {
        static void Main()
        {
            byte right = 0;
            byte left = 1;
            byte down = 2;
            byte up = 3;
            int lastFoodTime = 0;
            int foodDisappearTime = 8000;
            double negativePoints = 0;

            Position[] directions = new Position[]
            {//            row col
                new Position(0,1),// right
                new Position(0,-1),// left
                new Position(1,0),// down
                new Position(-1,0),// up
            };
            double sleepTime = 100;
            int direction = right;//Пазим индекса от този масив, което олицетворява посока на движение
            Random randomNumberGenerator = new Random();//Генерира ни произволно число в посочения диапазон
            Console.BufferHeight = Console.WindowHeight;//Казва на буфера да бъде голям колкото големината на прозореца, така неможем да трупаме елементи надолу до безкрай
            lastFoodTime = Environment.TickCount;// - текущите милисекунди от началото на пускане на компютъра до този момент
            List<Position> obstacles = new List<Position>()
            {
                new Position(randomNumberGenerator.Next(0, Console.WindowHeight - 1), randomNumberGenerator.Next(12 , Console.WindowWidth - 2))
            };
            foreach (var obstacle in obstacles)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(obstacle.col, obstacle.row);
                Console.Write("=");
            }
            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }
            foreach (Position position in snakeElements)
            {//Подаваме ги наобратно в SetCursorPosition, защото в него първо пишем колоната, после реда
                Console.SetCursorPosition(position.col, position.row);//Подаваме ги наобратно в SetCursorPosition, защото в него първо пишем колоната, после реда
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write('*');
            }
            Position food;
            do
            {
                food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight - 1), randomNumberGenerator.Next(0, Console.WindowWidth - 2));
            } while (snakeElements.Contains(food) || obstacles.Contains(food));
            Console.SetCursorPosition(food.col, food.row);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("@");

            while (true)
            {
                //negativePoints += 0.01;//Ако искаме с времето точките, които се получават за изядена ябълка да стават все по-малко
                if (Console.KeyAvailable)//Проверява дали потребителят е въвел някакво копче
                {
                    ConsoleKeyInfo userInput = Console.ReadKey(true);
                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        if (direction != right) direction = left;
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        if (direction != left) direction = right;
                    }
                    if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        if (direction != down) direction = up;
                    }
                    if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        if (direction != up) direction = down;
                    }
                }
                Position snakeHead = snakeElements.Last();//Връща координатите на главата
                Position nextDirection = directions[direction];//Взима новото положение на главата от масива directions, според клика със стрелките
                Position snakeNewHead = new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);//Взимаме координатите на следващата точка
                //Проверяваме дали са в границите
                if (snakeNewHead.col < 0) snakeNewHead.col = Console.WindowWidth - 2;//Ограничаваме го до предпоследната колона, защото 
                if (snakeNewHead.row < 0) snakeNewHead.row = Console.WindowHeight - 1;//когато отиде на последната автоматично създава нов ред и от там идват проблеми
                if (snakeNewHead.col > Console.WindowWidth - 2) snakeNewHead.col = 0;
                if (snakeNewHead.row > Console.WindowHeight - 1) snakeNewHead.row = 0;

                //Проверяваме дали не сме настъпили себе си
                if (snakeElements.Contains(snakeNewHead) || obstacles.Contains(snakeNewHead))
                {
                    string gameOver = "Game over!";
                    Console.SetCursorPosition((Console.WindowWidth - gameOver.Length) / 2, Console.WindowHeight / 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(gameOver);
                    int userPoints = snakeElements.Count - 6 - (int)negativePoints;
                    if (userPoints < 0) userPoints = 0;
                    string yourPoints = string.Format("Your points are: {0}", userPoints);
                    Console.SetCursorPosition((Console.WindowWidth - yourPoints.Length) / 2, Console.WindowHeight / 2 + 2);
                    Console.WriteLine(yourPoints);
                    string systemMessage = string.Format("Do you want to 'R' - Restart or 'Q' - Quit?");
                    Console.SetCursorPosition((Console.WindowWidth - systemMessage.Length) / 2, Console.WindowHeight / 2 + 4);
                    Console.WriteLine(systemMessage);
                    Console.SetCursorPosition((Console.WindowWidth) / 2, Console.WindowHeight / 2 + 6);
                    ConsoleKeyInfo answer = Console.ReadKey(true);
                    while (answer.Key != ConsoleKey.R && answer.Key != ConsoleKey.Q)
                    {
                        answer = Console.ReadKey(true);
                    }
                    if (answer.Key == ConsoleKey.Q)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        Main();
                    }
                    return;
                }
                Console.SetCursorPosition(snakeHead.col, snakeHead.row);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write('*');
                //Записваме новата точка и отпечатваме
                snakeElements.Enqueue(snakeNewHead);
                Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
                Console.ForegroundColor = ConsoleColor.Gray;
                if (direction == right) Console.Write(">");
                if (direction == left) Console.Write("<");
                if (direction == up) Console.Write("^");
                if (direction == down) Console.Write("v");
                if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                {
                    //Храним змията
                    do
                    {
                        food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight - 1), randomNumberGenerator.Next(0, Console.WindowWidth - 2));
                    } while (snakeElements.Contains(food) || obstacles.Contains(food));
                    lastFoodTime = Environment.TickCount;
                    Console.SetCursorPosition(food.col, food.row);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("@");
                    sleepTime--;//Забързваме змията с всяка изядена ябълка като намаляме SleepTime-a
                    Position obstacle;
                    do
                    {
                        obstacle = new Position(randomNumberGenerator.Next(0, Console.WindowHeight - 1), randomNumberGenerator.Next(0, Console.WindowWidth - 2));
                    } while (snakeElements.Contains(obstacle) || obstacles.Contains(obstacle) || (food.row == obstacle.row) || (food.col == obstacle.col));
                    obstacles.Add(obstacle);
                    Console.SetCursorPosition(obstacle.col, obstacle.row);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("=");
                }
                else
                {
                    //Движим се
                    Position last = snakeElements.Dequeue();//Маха най-първо вкарания елемент, т.е. опашката на змията и ни я връща като стойност
                    Console.SetCursorPosition(last.col, last.row);
                    Console.Write(" ");
                }

                if (Environment.TickCount - lastFoodTime >= foodDisappearTime)
                {
                    negativePoints = negativePoints + 1;//Ако храната изчезне ни се взимат точки
                    Console.SetCursorPosition(food.col, food.row);
                    Console.Write(" ");
                    do
                    {
                        food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight - 1), randomNumberGenerator.Next(0, Console.WindowWidth - 2));
                    } while (snakeElements.Contains(food) || obstacles.Contains(food));
                    lastFoodTime = Environment.TickCount;
                }

                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("@");

                sleepTime -= 0.01;//Забързваме я с времето, т.е. с всяко нарастване

                Thread.Sleep((int)sleepTime);//Спира действащата нишка за посочения брой милисекунди
            }
        }
    }
}
