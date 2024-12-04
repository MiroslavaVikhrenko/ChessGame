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


    }
}
