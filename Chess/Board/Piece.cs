namespace board
{
    class Piece
    {
        public Position? Position { get; set; }
        public Color Color { get; protected set; }
        public int AmountOfMoves { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            Board = board;
            Color = color;
            AmountOfMoves = 0;
        }
    }
}