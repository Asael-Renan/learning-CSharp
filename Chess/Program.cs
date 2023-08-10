using board;
using chessGame;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                ChessPosition chessPosition= new('c', 7);
                Console.WriteLine(chessPosition.ToPosition());
                

                Board board = new(8, 8);

                board.AddPiece(new Tower(board, Color.Black), new Position(0, 1));
                board.AddPiece(new Tower(board, Color.Black), new Position(0, 6));

                board.AddPiece(new Tower(board, Color.White), new Position(7, 1));
                board.AddPiece(new Tower(board, Color.White), new Position(7, 6));

                Screen.PrintBoard(board);
            }
            catch (BoardException error)
            {
                Console.WriteLine("Erro no tabuleiro: " + error.Message);
            }
        }
    }
}