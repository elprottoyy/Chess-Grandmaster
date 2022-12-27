public class ChessPiece
{
    public ChessPieceType Type { get; set; }
    public ChessPieceColor Color { get; set; }
    public int Row { get; set; }
    public int Column { get; set; }

    public ChessPiece(ChessPieceType type, ChessPieceColor color, int row, int column)
    {
        Type = type;
        Color = color;
        Row = row;
        Column = column;
    }
}
