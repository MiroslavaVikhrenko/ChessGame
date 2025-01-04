using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public abstract class Piece
    {
        public abstract PieceType Type { get; }
        public abstract Player Color { get; }
        //we need HasMoved because some moves are only legal if a piece has not moved yet
        public bool HasMoved { get; set; } = false; 
        public abstract Piece Copy();
        //the method returns a collection containing all the moves it can make
        //the position parameter is required because the pieces don't store their own position on the board       
        public abstract IEnumerable<Move> GetMoves(Position from, Board board);
        //3 of the pieces move using the similar pattern (bishop, rook, queen)
        //These pieces can all move as many positions as they want in certain directions
        //Helper method which returns all reachable positions in a given direction
        protected IEnumerable<Position> MovePositionsInDir(Position from, Board board, Direction dir)
        {
            //loop starts at the position "from" plus one step in the given direction => Position pos = from + dir
            //it continues while the position is inside the board => Board.IsInside(pos)
            //and after each iteration it takes another step => pos += dir
            //it's easy to do because of overloaded "+" operator
            for (Position pos = from + dir; Board.IsInside(pos); pos += dir)
            {
                //check if the current position is empty
                if (board.IsEmpty(pos))
                {
                    //if so, it is reachable and we can yield return it
                    yield return pos;
                    //and continue to the next position immediately
                    continue;
                }
                //otherwise there IS a piece at the position
                Piece piece = board[pos];
                //if it belongs to the opponent 
                if (piece.Color != Color)
                {
                    //then it can be captured, so its position is also reachable 
                    yield return pos;
                }
                //if the piece does not belong to the opponent => its position is NOT reachable 
                //but either way we encountered a piece and since the bishop, rook, queen canNOT jump =>
                //we don't have to check any more positions
                yield break;
            }
        }
    }
}
