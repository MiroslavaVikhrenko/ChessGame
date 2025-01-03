using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ChessLogic;

namespace ChessUI
{
    //purpose of this class is to load the pieces from the Assests folder
    //and make it convenient to access them
    public static class Images
    {
        //loaded images will be stored in 2 dictionaries - for white and black pieces
        //the key is a PieceType, the value is an ImageSource
        //So, the ides is that we can easily look up the correct image for a certain type of piece
        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new()
        {
            {PieceType.Pawn, LoadImage("Assets/PawnW.png") },
            {PieceType.Bishop, LoadImage("Assets/BishopW.png") },
            {PieceType.Knight, LoadImage("Assets/KnightW.png") },
            {PieceType.Rook, LoadImage("Assets/RookW.png") },
            {PieceType.Queen, LoadImage("Assets/QueenW.png") },
            {PieceType.King, LoadImage("Assets/KingW.png") }
        };
        private static readonly Dictionary<PieceType, ImageSource> blackSources = new()
        {
            {PieceType.Pawn, LoadImage("Assets/PawnB.png") },
            {PieceType.Bishop, LoadImage("Assets/BishopB.png") },
            {PieceType.Knight, LoadImage("Assets/KnightB.png") },
            {PieceType.Rook, LoadImage("Assets/RookB.png") },
            {PieceType.Queen, LoadImage("Assets/QueenB.png") },
            {PieceType.King, LoadImage("Assets/KingB.png") }
        };

        //Method to load images, it takes the relative path of an image as parameter
        //and returns a new BitmapImage where we pass in an URI with the given file path
        //and specify that it is a relative path
        private static ImageSource LoadImage(string filePath)
        {
            return new BitmapImage(new Uri(filePath,UriKind.Relative));
        }        
    }
}
