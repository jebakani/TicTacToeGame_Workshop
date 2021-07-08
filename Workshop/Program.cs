using System;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            char[] board =ticTacToeGame.CreateBoard();
            char playerChoice = ticTacToeGame.SelectOption();
            char computerChoice = playerChoice == 'X' ? 'O' : 'X';
            Console.WriteLine("Player choice:{0} Computer Choice:{1}",playerChoice,computerChoice);
            ticTacToeGame.DisplayBoard(board);
            board = ticTacToeGame.MovePosition(board, playerChoice);
        }
    }
}
