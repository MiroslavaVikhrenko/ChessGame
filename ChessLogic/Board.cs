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

        //to create a board without any pieces on it => the default constructor already does that
        //instead of creating a custom constructor I create a static method Initial()
        //Method to return a board with all the pieces set up correctly to start the game
        public static Board Initial()
        {
            //first create a new empty board
            Board board = new Board();

            //next - add all the pieces
            board.AddStartPieces();

            return board;
        }

        private void AddStartPieces()
        {
            //add the black pieces in the top row
            this[0, 0] = new Rook(Player.Black);
            this[0, 1] = new Knight(Player.Black);
            this[0, 2] = new Bishop(Player.Black);
            this[0, 3] = new Queen(Player.Black);
            this[0, 4] = new King(Player.Black);
            this[0, 5] = new Bishop(Player.Black);
            this[0, 6] = new Knight(Player.Black);
            this[0, 7] = new Rook(Player.Black);

            //add the white pieces in the bottom row
            this[7, 0] = new Rook(Player.White);
            this[7, 1] = new Knight(Player.White);
            this[7, 2] = new Bishop(Player.White);
            this[7, 3] = new Queen(Player.White);
            this[7, 4] = new King(Player.White);
            this[7, 5] = new Bishop(Player.White);
            this[7, 6] = new Knight(Player.White);
            this[7, 7] = new Rook(Player.White);

            //add the pawns for both players
            for (int c = 0; c < 8; c++)
            {
                this[1,c] = new Pawn(Player.Black);
                this[6, c] = new Pawn(Player.White);
            }
        }

        //Method to check if position is valid - convenient for move generation
        public static bool IsInside(Position pos)
        {
            return pos.Row >= 0 && pos.Row < 8 && pos.Column >= 0 && pos.Column < 8;
        }
    }
}
