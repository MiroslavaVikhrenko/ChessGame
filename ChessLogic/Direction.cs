using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    //this class will be convenient when we generate moves because all pieces move in certain directions
    public class Direction
    {
        //we represent a direction as a row delta and a column delta 
        //that is the change in row and column from a given position
        public int RowDelta { get; }
        public int ColumnDelta { get; }

        //The Constructor
        public Direction (int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            ColumnDelta = columnDelta;
        }

        //it will be convenient to have an ability to add two directions together => for that we will override + operator
        public static Direction operator +(Direction dir1, Direction dir2)
        {
            return new Direction(dir1.RowDelta + dir2.RowDelta, dir1.ColumnDelta + dir2.ColumnDelta);
        }

        //override * operator as well so that we can scale a direction
    }
}
