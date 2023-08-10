using board;

namespace Chess
{
    class Screen
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Rows; i++)
            {
                for (int j = 0; j < board.Columns; j++)
                {
                    Piece piece = board.Piece(i, j);
                    if (piece != null)
                    {
                        Console.Write(piece + " ");
                    } else {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}