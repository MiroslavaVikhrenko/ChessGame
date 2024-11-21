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


    //a common operation we need is to find an opponent of a given player
    //so for convenience let's add an extension method to Player => I'll add a static class here called PlayerExtensions

    public static class PlayerExtensions
    {
        //Method to find Opponent, it takes a player as parameter and returns that player's opponent
        public static Player Opponent(this Player player)
        {
            //We switch on the player parameter 
            return player switch
            {
                //if it's player White => we return player Black
                Player.White => Player.Black,
                //if it's player Black => we return player White
                Player.Black => Player.White,
                //we always pass either player White or Black, but to make the code compile we also add default case which returns player None
                _ => Player.None,
            };
        }
    }
}
