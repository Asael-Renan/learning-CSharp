using board;

namespace chessGame
{
    class ChessMatch
    {
        public Board? BoardMatch { get; private set; }
        private int Turn;
        private Color CurrentPlayer;
        public bool Finished { get; private set; }

        public ChessMatch()
        {
            BoardMatch = new Board(8, 8);
            Turn = 1;
            CurrentPlayer = Color.White;
            Finished = false;
            PlacePiece();
        }

        public void MakeMoviment(Position Origem, Position Destination)
        {
            Piece? p = BoardMatch?.RemovePiece(Origem);
            p?.IncreaseTheAmountOfMovements();
            Piece? CapturedPiece = BoardMatch?.RemovePiece(Destination);
            BoardMatch?.AddPiece(p, Destination);

        }

        private void PlacePiece()
        {
            BoardMatch?.AddPiece(new Tower(BoardMatch, Color.Black), new ChessPosition('c', 1).ToPosition());
            BoardMatch?.AddPiece(new Tower(BoardMatch, Color.Black), new ChessPosition('e', 1).ToPosition());
            BoardMatch?.AddPiece(new Tower(BoardMatch, Color.Black), new ChessPosition('d', 2).ToPosition());
            BoardMatch?.AddPiece(new King(BoardMatch, Color.Black), new ChessPosition('d', 1).ToPosition());

            BoardMatch?.AddPiece(new Tower(BoardMatch, Color.White), new ChessPosition('c', 8).ToPosition());
            BoardMatch?.AddPiece(new Tower(BoardMatch, Color.White), new ChessPosition('e', 8).ToPosition());
            BoardMatch?.AddPiece(new Tower(BoardMatch, Color.White), new ChessPosition('d', 7).ToPosition());
            BoardMatch?.AddPiece(new King(BoardMatch, Color.White), new ChessPosition('d', 8).ToPosition());
        }
    }
}
