using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    //this class will be used for all moves that simply move the piece from one position to another
    //the move may capture an opponent piece but otherwise it won't have any side effects
    public class NormalMove : Move
    {
        public override MoveType Type => MoveType.Normal;
        public override Position FromPos { get; }
        public override Position ToPos { get; }
        public NormalMove(Position from, Position to)
        {
            FromPos = from;
            ToPos = to;
        }

        public override void Execute(Board board)
        {
            //the code that actually make the move happen : need to take the piece at "from" position and move it to "to" position
            //first take the piece at "from" position
            Piece piece = board[FromPos];
            //then place it to "to" position
            board[ToPos] = piece;
            //remove it from its original position
            board[FromPos] = null;
            //set the piece's HasMoved property to "true"
            piece.HasMoved = true;
        }
    }
}
