using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    //the enum Player will be used to store which player's turn it is and who won the game
    //we also use it to represent the color of the chess pieces
    //it will have 3 values: None, White, Black
    public enum Player
    {
        None,
        White,
        Black
    }

    //the None value is useful because we can set the winning player to none in case of a draw
}
