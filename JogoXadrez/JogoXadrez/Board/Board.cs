namespace Board
{
    class board
    {
        public int lines { get; set; }
        public int rows { get; set; }
        private ChessPiece[,] piece;

        public board(int lines, int rows)
        {
            this.lines = lines;
            this.rows = rows;
            piece = new ChessPiece[lines, rows];
        }
    }
}
