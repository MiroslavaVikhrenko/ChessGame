using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    //contain a value for each type of move in the game (normal + special moves)
    //Рокировка - Castling
    public enum MoveType
    {
        Normal,
        CastleKS,
        CastleQS,
        DoublePawn,
        EnPassant,
        PawnPromotion
    }
}
