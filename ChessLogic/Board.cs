using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    //the Board class will store all the active pieces of the game and provide various helper methods
    public class Board
    {
        //rectangular array for storing the pieces
        //it must have 8 rows and 8 colums (because the chess board is 8x8)
        //array is private - access will be given by indexer
        private readonly Piece[,] pieces = new Piece[8, 8];

        public Piece this[int row, int col]
        {
            get { return pieces[row, col]; }
            set { pieces[row, col] = value; }
        }

        //another indexer to use Position object as an index
        public Piece this[Position pos]
        {
            //unpack the given position and call the first indexer
            get { return this[pos.Row, pos.Column]; }
            set { this[pos.Row, pos.Column] = value; }
        }
    }
}
