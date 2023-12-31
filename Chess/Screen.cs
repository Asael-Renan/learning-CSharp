using board;

namespace Chess
{
    class Screen
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    Piece piece = board.Piece(i, j);
                    if (piece != null)
                    {
                        Screen.PrintPiece(piece);
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.White)
            {
                Console.Write(piece + " ");
            }
            if (piece.Color == Color.Black) {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece + " ");
                Console.ForegroundColor = aux;
            }
        }
    }
}