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

                ChessMatch match = new();

                while (!match.Finished)
                {
                    Console.Clear();
                    Screen.PrintBoard(match.BoardMatch);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Position Origin = Screen.ReadChessPosition().ToPosition();
                    Console.Write("Destino: ");
                    Position Destiny = Screen.ReadChessPosition().ToPosition();

                    match.MakeMoviment(Origin, Destiny);
                }
            }
            catch (BoardException error)
            {
                Console.WriteLine("Erro no tabuleiro: " + error.Message);
            }
        }
    }
}
