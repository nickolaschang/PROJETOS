using System;
using Board;
namespace JogoXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
           board board = new board(8,8);
           ConsoleSystem.BoardTable(board);
           
        }
    }
}
