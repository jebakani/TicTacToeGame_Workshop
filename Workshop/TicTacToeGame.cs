using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    class TicTacToeGame
    {
        public char[] board;
        public char[] CreateBoard()
        {
            board = new char[10];

            for(int i=1;i<10;i++)
            {
                board[i] = ' ';
            }

            Console.WriteLine("Empty board created");
            return board;
        }

        public char SelectOption()
        {
            Console.WriteLine("Enter your choice as X or O");
            char choice = Convert.ToChar(Console.ReadLine());

            if(char.ToUpper(choice)!= 'X' && char.ToUpper(choice) !='O')
            {
                Console.WriteLine("Enter either X or O");
                choice = SelectOption();
            }

            return char.ToUpper(choice);
        }

        public void DisplayBoard(char[] board)
        {
            Console.WriteLine("---------------------");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);

            Console.WriteLine("---------------------");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);

            Console.WriteLine("_--------------------");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);

            Console.WriteLine("---------------------");
        }

        public char[] MovePosition(char[] board , char symbol)
        {
            int position = 1;
            DisplayBoard(board);
            Console.WriteLine("Enter your choice of position from 1 to 9 :");
            int posChoice = Convert.ToInt32(Console.ReadLine());
            if(board[posChoice]==' ')
            {
                board[posChoice] = symbol;
            }
            else
            {
                Console.WriteLine("Position is already occupied.\nChoose another position");
                board = MovePosition(board, symbol);

            }
            DisplayBoard(board);
            return board;
        }

    }

}
    
