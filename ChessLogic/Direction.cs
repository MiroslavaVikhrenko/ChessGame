namespace ChessLogic
{
    //this class will be convenient when we generate moves because all pieces move in certain directions
    public class Direction
    {
        //add all basic directions we need - we start with North (= UP) direction
        //to move up from a given position we subtract 1 row and leave the column unchanged =>
        //the RowDelta should be -1, ColumnDelta should be 0
        public readonly static Direction North = new Direction(-1, 0);
        public readonly static Direction South = new Direction(1, 0);
        public readonly static Direction East = new Direction(0, 1);
        public readonly static Direction West = new Direction(0, -1);

        //add directions for diagonal moves => we can use overloaded + operator
        public readonly static Direction NorthEast = North + East;
        public readonly static Direction NorthWest = North + West;
        public readonly static Direction SouthEast = South + East;
        public readonly static Direction SouthWest = South + West;

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

        //it will be convenient to have an ability to add two directions together => for that we will overwrite + operator
        public static Direction operator +(Direction dir1, Direction dir2)
        {
            return new Direction(dir1.RowDelta + dir2.RowDelta, dir1.ColumnDelta + dir2.ColumnDelta);
        }

        //overwrite * operator as well so that we can scale a direction
        public static Direction operator *(int scalar, Direction dir)
        {
            return new Direction(scalar * dir.RowDelta, scalar * dir.ColumnDelta);
        }

    }
}
