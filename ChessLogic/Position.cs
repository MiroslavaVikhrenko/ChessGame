using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    //this class represents a position or square on the board
    public class Position
    {
        //we use the convention that the square at row 0 and column 0 is the upper left corner
        //this implies that rows increase from top to bottom and columns increase from left to right
        public int Row { get; }
        public int Column { get; }

        //add a Constructor
        public Position (int row, int column)
        {
            Row = row;
            Column = column;
        }

        //later it will be convenient to know the color of the square at a given position
        //the position 0,0, for example, is a white/light square, whereas a position 2,1 is a black/dark square
        //to support this check we add a SquareColor() method

        //Method to check the color for a square

        public Player SquareColor()
        {
            //it returns a player value because we also use player to represent colors
            //if the sume of the row and column is even => then the square is 'white'
            if ((Row + Column) % 2 == 0)
            {
                return Player.White;
            }
            //otherwise if the sum is odd => then the square is 'black'
            return Player.Black;
        }

    }
}
