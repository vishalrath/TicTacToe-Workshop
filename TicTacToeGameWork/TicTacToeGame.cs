using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGameWork
{
    class TicTacToeGame
    {
        public void CreateBoard()
        {
            char[] board = new char[10] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(board[i]);
            }
        }
    }
}
