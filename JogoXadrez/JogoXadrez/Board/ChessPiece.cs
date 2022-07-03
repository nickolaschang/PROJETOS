namespace Board
{
    class ChessPiece
    {
        public Position position { get; set; }
        public Colour colour { get; protected set; }
        public int moveQty { get; protected set; }
        public board board { get; protected set; }

        public ChessPiece(Position position, Colour colour, board board)
        {
            this.position = position;
            this.colour = colour;
            this.board = board;
            this.moveQty = 0;
        }
    }
}
