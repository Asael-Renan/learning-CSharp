namespace board
{
    class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece?[,] Pieces;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece?[Rows, Columns];
        }

        public Piece? Piece(int row, int column)
        {
            return Pieces[row, column];
        }

        public Piece? Piece(Position position)
        {
            return Pieces[position.X, position.Y];
        }

        public void AddPiece(Piece piece, Position position)
        {
            if (PieceExists(position))
            {
                throw new BoardException("Já existe uma peça na posição: " + position);
            }
            Pieces[position.X, position.Y] = piece;
            piece.Position = position;
        }

        public Piece? RemovePiece(Position pos)
        {
            if (Piece(pos) == null)
            {
                return null;
            }

            Piece? aux = Piece(pos);
            Pieces[pos.X, pos.Y] = null;
            return aux;
        }

        public bool PieceExists(Position position)
        {
            ValidatePosition(position);
            return Piece(position) != null;
        }

        public bool ValidPosition(Position position)
        {
            if (position.X <  0 || position.X >= Rows || position.Y <  0 || position.Y >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Posição inválida!");
            }
        }
    }
}