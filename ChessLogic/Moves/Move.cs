using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    //Base abstract class for all concrete moves
    public abstract class Move
    {
        public abstract MoveType Type { get; }
        //"From" position = this is where the piece moves from
        public abstract Position fromPos { get; }
        //"To" position = this is where the piece moves to
        public abstract Position toPos { get; }
        //a bit like the command design pattern
        public abstract void Execute(Board board);
    }
}
