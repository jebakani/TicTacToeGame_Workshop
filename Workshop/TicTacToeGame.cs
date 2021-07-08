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
        public void CreateBoard()
        {
             board = new char[10];
            Console.WriteLine("Empty board created");
        }
    }
}
    
