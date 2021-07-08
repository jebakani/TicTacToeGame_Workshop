using System;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.CreateBoard();
        }
    }
}
