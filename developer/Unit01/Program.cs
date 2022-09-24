using System;
using System.Collections.Generic;

namespace cse210_KennethBenting_csharp_tictactoe_complete
{
    /// <summary>
    /// This is a simple Tic Tac Toe game with a 3x3 grid.
    /// (I was trying to use a Tic Tac Toe game with modified grid but it is too difficult.)
    ///(I hope to get more training on this.)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<string> boardGame = GetNewBoard();
            string currentPlayer = "x";

            while (!GameIsFinished(boardGame))
            {
                DisplayBoard(boardGame);

                int squareChoice = UserInput(currentPlayer);
                MakeMove(boardGame, squareChoice, currentPlayer);

                currentPlayer = NextPlayerTurn(currentPlayer);
            }

            DisplayBoard(boardGame);
            Console.WriteLine("That's a great game. Please play again!");
        }

        /// <summary>
        /// This will display the board with the 3x3 dimension. 
        /// </summary>
        /// <param name="board">The board</param>
        static void DisplayBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

        /// <summary>
        /// We will create a board that have a 3x3 dimension.
        /// </summary>
        /// <returns>This will return a list of string with 9 squares.</returns>
        static List<string> GetNewBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                board.Add(i.ToString());
            }

            return board;
        }

        /// <summary>
        /// Switching to the 2 players with "x" and "o" as their variable.
        /// </summary>
        /// <param name="currentPlayer">The current player's symbol (x or o)</param>
        /// <returns>The next player's symbol (x or o)</returns>
        static string NextPlayerTurn(string currentPlayer)
        {
            string nextPlayer = "x";

            if (currentPlayer == "x")
            {
                nextPlayer = "o";
            }

            return nextPlayer;
        }        

        /// <summary>
        /// We can know if the game is already finished or not.
        /// </summary>
        /// <param name="board">The current board.</param>
        /// <returns>True if the game is finished.</returns>
        static bool GameIsFinished(List<string> board)
        {
            bool gameFinished = false;

            if (PlayerWins(board, "x") || PlayerWins(board, "o") || Draw(board))
            {
                gameFinished = true;
            }

            return gameFinished;
        }
        /// <summary>
        /// We can try to check if the player has won the game of Tic Tac Toe.
        /// </summary>
        /// <param name="board">The current board</param>
        /// <param name="player">To see player's status</param>
        /// <returns></returns>
        static bool PlayerWins(List<string> board, string player)
        {

            bool playerWins = false;

            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)                                
                )
            {
                playerWins = true;
            }

            return playerWins; 
        }

        /// <summary>
        /// We need to check if there is still a space available on the boardgame.
        /// </summary>
        /// <param name="board">The current board.</param>
        /// <returns>True if the board is full.</returns>
        static bool Draw(List<string> board)
        {
            // If there is an empty space, a move can still be made.
            bool totalDigit = false;

            foreach (string value in board)
            {
                if (char.IsDigit(value[0]))
                {
                    totalDigit = true;
                    break;
                }
            }

            return !totalDigit;
        }

        /// <summary>
        /// Get's the number from the user that he/she wants to change into the player's symbol (x or o).
        /// </summary>
        /// <param name="currentPlayer">The sign (x or o) of the current player.</param>
        /// <returns>A 1-based spot number (not a 0-based index)</returns>
        static int UserInput(string currentPlayer)
        {
            Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
            int squareChoice = int.Parse(Console.ReadLine());
            return squareChoice;
        }

        /// <summary>
        /// This changes to the digit in the board game into the current player's symbol.
        /// </summary>
        /// <param name="board">The current board</param>
        /// <param name="choice">The 1-based spot number (not a 0-based index).</param>
        /// <param name="currentPlayer">The current player's symbol (x or o)</param>
        static void MakeMove(List<string> board, int choice, string currentPlayer)
        {
            // Convert the 1-based spot number to a 0-based index.
            int index = choice - 1;
            
            board[index] = currentPlayer;
        }
    }
}