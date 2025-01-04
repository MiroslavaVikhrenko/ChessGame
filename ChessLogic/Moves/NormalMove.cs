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
    }
}
