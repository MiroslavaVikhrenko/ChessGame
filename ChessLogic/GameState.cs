using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    //class that represents the entire state of the game (UI will interact with this class)   
    public class GameState
    {
        //store the current board configuration
        public Board Board {  get; }
        //which player's turn it is
        public Player CurrentPlayer { get; private set; }

        //Why do we take the player and the board as parameters in constructor?
        //In chess white always starts and we saw how the board should look initially
        //But taking parameters like this makes it easy to test out certain scenarios and make sure they work
        public GameState(Player player, Board board)
        {
            CurrentPlayer = player;
            Board = board;
        }
    }
}
