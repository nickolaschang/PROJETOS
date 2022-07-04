using System;
using Board;
namespace JogoXadrez
{
    class ConsoleSystem
    {
        public static void BoardTable(board board)
        {
            for (int i = 0; i < board.line; i++)
            {
                for (int j = 0; j < board.row; j++)
                {
                    if (board.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.piece(i, j) + " ");
                    }

                }
                Console.WriteLine();
            }

        }

    }
}
