using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PingPong
{
    class PingPong
    {
        static int firstPlayerPadSize = 6;
        static int secondPlayerPadSize = 6;
        static int firstPlayerStartRow = Console.WindowHeight / 2 - firstPlayerPadSize / 2;
        static int firstPlayerStartCol = 1;
        static int secondPlayerStartRow = Console.WindowHeight / 2 - secondPlayerPadSize / 2;
        static int secondPlayerStartCol = Console.WindowWidth - 3;
        static LinkedList<int> firstPlayer = new LinkedList<int>();
        static LinkedList<int> secondPlayer = new LinkedList<int>();
        static int ballPositionX = 0;
        static int ballPositionY = 0;
        static bool ballIncrementRow = true;
        static bool ballIncrementCol = true;
        static int firstPlayerResultPoints = 0;
        static int secondPlayerResultPoints = 0;
        static string result;
        private static readonly object _lock = new object();
        static Random randomGenerator = new Random();

        private static void RemoveScrollBars()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        private static void PrintAtPosition(int x, int y, string symbol)
        {
            lock (_lock)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            }
        }

        private static void SetBallAtTheMiddleOfTheGameField()
        {
            ballPositionX = Console.WindowWidth / 2;
            ballPositionY = Console.WindowHeight / 2;
            int direction = randomGenerator.Next(0, 2);
            ballIncrementRow = direction == 0 ? true : false;
            direction = randomGenerator.Next(0, 2);
            ballIncrementCol = direction == 0 ? true : false;

        }

        private static void DrawPlayer(LinkedList<int> player, int playerPadSize, int startRow, int startColumn)
        {
            for (int i = startRow; i < startRow + playerPadSize; i++)
            {
                player.AddLast(i);
                Console.SetCursorPosition(startColumn, i);
                Console.Write("||");
            }
        }

        private static void MovePlayer()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (firstPlayer.First() > 0 && key.Key == ConsoleKey.W)
                    {//След всеки if да си дефинирам нова нишка за всяко от четерите действия
                     //var moveFirstUp = Task.Factory.StartNew(() => MovePlayerUp(firstPlayer, firstPlayerStartCol));
                        MovePlayerUp(firstPlayer, firstPlayerStartCol);
                    }
                    else if (firstPlayer.Last() < Console.WindowHeight - 1 && key.Key == ConsoleKey.S)
                    {
                        //var moveFirstDown = Task.Factory.StartNew(() => MovePlayerDown(firstPlayer, firstPlayerStartCol));
                        MovePlayerDown(firstPlayer, firstPlayerStartCol);
                    }
                    else if (secondPlayer.First() > 0 && key.Key == ConsoleKey.UpArrow)
                    {
                        //var moveSecondUp = Task.Factory.StartNew(() => MovePlayerUp(secondPlayer, secondPlayerStartCol));
                        MovePlayerUp(secondPlayer, secondPlayerStartCol);
                    }
                    else if (secondPlayer.Last() < Console.WindowHeight - 1 && key.Key == ConsoleKey.DownArrow)
                    {
                        //var moveSecondDown = Task.Factory.StartNew(() => MovePlayerDown(secondPlayer, secondPlayerStartCol));
                        MovePlayerDown(secondPlayer, secondPlayerStartCol);
                    }
                }
            }
        }

        private static void MovePlayerUp(LinkedList<int> player, int playerCol)
        {
            int newElement = player.First() - 1;
            player.AddFirst(newElement);
            PrintAtPosition(playerCol, newElement, "||");
            int lastElement = player.Last();
            PrintAtPosition(playerCol, lastElement, "  ");
            player.RemoveLast();
        }

        private static void MovePlayerDown(LinkedList<int> player, int playerCol)
        {
            int newElement = player.Last() + 1;
            player.AddLast(newElement);
            PrintAtPosition(playerCol, newElement, "||");
            int firstElement = player.First();
            PrintAtPosition(playerCol, firstElement, "  ");
            player.RemoveFirst();
        }

        private static void DisplayEndGameMessage(string player)
        {
            string whoWins = string.Format($"{player} player wins!");
            Console.SetCursorPosition(Console.WindowWidth / 2 - whoWins.Length / 2, Console.WindowHeight / 2 - 1);
            Console.Write(whoWins);
            string systemMessage = string.Format("Do you want to 'R' - Restart or 'Q' - Quit?");
            Console.SetCursorPosition((Console.WindowWidth - systemMessage.Length) / 2, Console.WindowHeight / 2 + 1);
            Console.Write(systemMessage);
            Console.SetCursorPosition((Console.WindowWidth) / 2, Console.WindowHeight / 2 + 6);
            ConsoleKeyInfo answer = Console.ReadKey(true);

            while (answer.Key != ConsoleKey.R && answer.Key != ConsoleKey.Q)
            {//Този while блокира всички други клавиши, затова играчите не се движат докато не изберем
                answer = Console.ReadKey(true);
            }
            if (answer.Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - whoWins.Length / 2, Console.WindowHeight / 2 - 1);
                Console.Write(new string(' ', whoWins.Length));
                Console.SetCursorPosition((Console.WindowWidth - systemMessage.Length) / 2, Console.WindowHeight / 2 + 1);
                Console.Write(new string(' ', systemMessage.Length));
            }
        }

        private static void PrintResult()
        {
            result = string.Format($"{firstPlayerResultPoints} - {secondPlayerResultPoints}");
            Console.SetCursorPosition((Console.WindowWidth - result.Length) / 2, 1);
            Console.WriteLine(result);
        }

        private static void MoveBall()
        {
            PrintAtPosition(ballPositionX, ballPositionY, " ");
            if (ballPositionX <= 3)
            {
                if (ballPositionY >= firstPlayer.First()
                    && ballPositionY <= firstPlayer.Last())
                {
                    ballIncrementRow = !ballIncrementRow;
                }
                else
                {
                    SetBallAtTheMiddleOfTheGameField();
                    secondPlayerResultPoints++;
                    PrintResult();
                    DisplayEndGameMessage("Second");
                }
            }

            if (ballPositionX >= Console.WindowWidth - 4)
            {
                if (ballPositionY >= secondPlayer.First()
                      && ballPositionY <= secondPlayer.Last())
                {
                    ballIncrementRow = !ballIncrementRow;
                }
                else
                {
                    SetBallAtTheMiddleOfTheGameField();
                    firstPlayerResultPoints++;
                    PrintResult();
                    DisplayEndGameMessage("First");
                }
            }
            if (ballPositionY == 0 || ballPositionY == Console.WindowHeight - 1)
            {
                ballIncrementCol = !ballIncrementCol;
            }
            ballPositionX += ballIncrementRow ? 1 : -1;
            ballPositionY += ballIncrementCol ? 1 : -1;
            PrintAtPosition(ballPositionX, ballPositionY, "@");
            if (ballPositionX >= Console.WindowWidth / 2 - result.Length / 2 &&
                ballPositionX <= Console.WindowWidth / 2 + result.Length / 2 &&
                    ballPositionY == 1)
            {//Ако стъпим на надписа да не го затрием
                PrintResult();
            }
        }

        static void Main()
        {
            RemoveScrollBars();
            Console.CursorVisible = false;
            var taskMovingPlayers = Task.Factory.StartNew(() => MovePlayer());
            SetBallAtTheMiddleOfTheGameField();
            PrintAtPosition(ballPositionX, ballPositionY, "@");
            DrawPlayer(firstPlayer, firstPlayerPadSize, firstPlayerStartRow, firstPlayerStartCol);
            DrawPlayer(secondPlayer, secondPlayerPadSize, secondPlayerStartRow, secondPlayerStartCol);
            PrintResult();
            while (true)
            {
                MoveBall();
                Thread.Sleep(60);
            }
        }
    }
}
