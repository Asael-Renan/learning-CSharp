namespace board
{
    class Piece
    {
        public Position? Position { get; set; }
        public Color Color { get; protected set; }
        public int AmountOfMovements { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            Board = board;
            Color = color;
            AmountOfMovements = 0;
        }

        public void IncreaseTheAmountOfMovements() {
            AmountOfMovements++;
        }
    }
}