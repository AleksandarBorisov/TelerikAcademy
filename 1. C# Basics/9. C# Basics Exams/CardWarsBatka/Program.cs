using System;

namespace CardWarsBatka
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int finalPlayerOneScore = 0;
            int finalPlayerTwoScore = 0;
            int gamesForPOne = 0;
            int gamesForPTwo = 0;
            bool playerOneWins = false;
            bool playerTwoWins = false;
            for (int i = 0; i < n; i++)
            {
                int playerCard = 0;
                int playerOneScore = 0;
                int playerTwoScore = 0;
                playerOneWins = false;
                playerTwoWins = false;
                while (playerCard < 6)
                {
                    string cardSign = Console.ReadLine();
                    if (playerCard < 3)//Ръката на първия играч
                    {
                        switch (cardSign)
                        {
                            case "A": playerOneScore += 1; break;
                            case "J": playerOneScore += 11; break;
                            case "Q": playerOneScore += 12; break;
                            case "K": playerOneScore += 13; break;
                            case "Z": playerOneScore *= 2; break;
                            case "Y": playerOneScore -= 200; break;
                            case "X": playerOneWins = true; break;
                            default: playerOneScore += 12 - int.Parse(cardSign); break;
                        }
                    }
                    else//Ръката на втория играч
                    {
                        switch (cardSign)
                        {
                            case "A": playerTwoScore += 1; break;
                            case "J": playerTwoScore += 11; break;
                            case "Q": playerTwoScore += 12; break;
                            case "K": playerTwoScore += 13; break;
                            case "Z": playerTwoScore *= 2; break;
                            case "Y": playerTwoScore -= 200; break;
                            case "X": playerTwoWins = true; break;
                            default: playerTwoScore += 12 - int.Parse(cardSign); break;
                        }
                    }
                    playerCard++;
                }//end of while
                if (playerOneWins && playerTwoWins)
                {
                    playerOneScore += 50;
                    playerTwoScore += 50;
                }
                else if (playerOneWins || playerTwoWins)
                {
                    break;
                }
                else if (playerOneScore > playerTwoScore)
                {
                    gamesForPOne++;
                    finalPlayerOneScore += playerOneScore;
                }
                else if (playerOneScore < playerTwoScore)
                {
                    gamesForPTwo++;
                    finalPlayerTwoScore += playerTwoScore;
                }
            }//end of for
            if (playerOneWins)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
            }
            else if (playerTwoWins)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
            }
            else if (finalPlayerOneScore > finalPlayerTwoScore)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine();
                Console.WriteLine("Score: {0}", finalPlayerOneScore);
                Console.WriteLine();
                Console.WriteLine("Games won: {0}", gamesForPOne);
            }
            else if (finalPlayerOneScore < finalPlayerTwoScore)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine();
                Console.WriteLine("Score: {0}", finalPlayerTwoScore);
                Console.WriteLine();
                Console.WriteLine("Games won: {0}", gamesForPTwo);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine();
                Console.WriteLine("Score: {0}", finalPlayerTwoScore);
            }
        }
    }
}
