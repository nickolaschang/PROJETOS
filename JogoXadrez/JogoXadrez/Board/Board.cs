namespace Board
{
    class board
    {
        public int line { get; set; }
        public int row { get; set; }
        private ChessPiece[,] pieces;

        public board(int line, int row)
        {
            this.line = line;
            this.row = row;
            pieces = new ChessPiece[line, row];
        }
        public ChessPiece piece(int line, int row)
        {
            return pieces[line, row];
        }
    }
}
