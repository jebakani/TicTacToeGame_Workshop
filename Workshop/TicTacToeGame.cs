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
    }
}
    
