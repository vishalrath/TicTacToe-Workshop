using System;

namespace TicTacToeGameWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TicTacToeGame obj = new TicTacToeGame();
            obj.CreateBoard();

            TicTacToeGame obj1 = new TicTacToeGame();
            obj1.SelectLetter();
            Console.ReadLine();
        }
    }
}
