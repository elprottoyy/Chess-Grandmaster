public class ChessBoard
{
    private ChessPiece[,] _board = new ChessPiece[8, 8];

    public void Initialize()
    {
        // Initialize the white pieces
        _board[0, 0] = new ChessPiece(ChessPieceType.Rook, ChessPieceColor.White, 0, 0);
        _board[0, 1] = new ChessPiece(ChessPieceType.Knight, ChessPieceColor.White, 0, 1);
        _board[0, 2] = new ChessPiece(ChessPieceType.Bishop, ChessPieceColor.White, 0, 2);
        _board[0, 3] = new ChessPiece(ChessPieceType.Queen, ChessPieceColor.White, 0, 3);
        _board[0, 4] = new ChessPiece(ChessPieceType.King, ChessPieceColor.White, 0, 4);
        _board[0, 5] = new ChessPiece(ChessPieceType.Bishop, ChessPieceColor.White, 0, 5);
        _board[0, 6] = new ChessPiece(ChessPieceType.Knight, ChessPieceColor.White, 0, 6);
        _board[0, 7] = new ChessPiece(ChessPieceType.Rook, ChessPieceColor.White, 0, 7);

        // Initialize the white pawns
        for (int i = 0; i < 8; i++)
        {
            _board[1, i] = new ChessPiece(ChessPieceType.Pawn, ChessPieceColor.White, 1, i);
        }

        // Initialize the black pieces
        _board[7, 0] = new ChessPiece(ChessPieceType.Rook, ChessPieceColor.Black, 7, 0);
        _board[7, 1] = new ChessPiece(ChessPieceType.Knight, ChessPieceColor.Black, 7, 1);
        _board[
